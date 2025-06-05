using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ProiectPAW;

namespace ProiectPAW
{
    public partial class FormTranzactii : Form
    {
      
        private List<Client> listaClientiDisponibili;
        private List<Produs> listaProduseDisponibile;

       
        private List<ProdusTranzactie> produseInTranzactieCurenta;

     
        public Tranzactie TranzactieNoua { get; private set; }


        public FormTranzactii(List<Client> clienti, List<Produs> produse)
        {
            InitializeComponent();

            listaClientiDisponibili = clienti;
            listaProduseDisponibile = produse; 

            produseInTranzactieCurenta = new List<ProdusTranzactie>();
            TranzactieNoua = null;
        }

        private void FormTranzactii_Load(object sender, EventArgs e)
        {
            PopuleazaCmbClienti();
            PopuleazaCmbProduse();
            ConfigureazaDgvProduseTranzactie();
            ActualizeazaValoareTotala();
        }

        private void PopuleazaCmbClienti()
        {
            cmbClienti.DataSource = null;
            cmbClienti.DataSource = listaClientiDisponibili;
            cmbClienti.DisplayMember = "NumeClient"; 
            cmbClienti.ValueMember = "ClientId";     
            if (cmbClienti.Items.Count > 0)
                cmbClienti.SelectedIndex = 0;
        }

        private void PopuleazaCmbProduse()
        {
            cmbProduseTranzactie.DataSource = null;
          
            cmbProduseTranzactie.DataSource = listaProduseDisponibile.Where(p => p.CantitateStoc > 0).ToList();
            cmbProduseTranzactie.DisplayMember = "Denumire";
            cmbProduseTranzactie.ValueMember = "IdProdus";
            if (cmbProduseTranzactie.Items.Count > 0)
                cmbProduseTranzactie.SelectedIndex = 0;
        }

        private void ConfigureazaDgvProduseTranzactie()
        {
            dgvProduseTranzactie.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDenumire = new DataGridViewTextBoxColumn();
            colDenumire.DataPropertyName = "ProdusulDenumire"; 
            colDenumire.HeaderText = "Denumire Produs";
            colDenumire.Name = "colDenumire";
            colDenumire.ReadOnly = true;
            colDenumire.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduseTranzactie.Columns.Add(colDenumire);

            DataGridViewTextBoxColumn colCantitate = new DataGridViewTextBoxColumn();
            colCantitate.DataPropertyName = "CantitateVanduta";
            colCantitate.HeaderText = "Cantitate";
            colCantitate.Name = "colCantitate";
            colCantitate.ReadOnly = true;
            dgvProduseTranzactie.Columns.Add(colCantitate);

            DataGridViewTextBoxColumn colPretUnitar = new DataGridViewTextBoxColumn();
            colPretUnitar.DataPropertyName = "PretLaMomentulVanzarii";
            colPretUnitar.HeaderText = "Pret Unitar";
            colPretUnitar.Name = "colPretUnitar";
            colPretUnitar.DefaultCellStyle.Format = "C2";
            colPretUnitar.ReadOnly = true;
            dgvProduseTranzactie.Columns.Add(colPretUnitar);

            DataGridViewTextBoxColumn colValoareLinie = new DataGridViewTextBoxColumn();
            colValoareLinie.DataPropertyName = "ValoareLinie"; 
            colValoareLinie.HeaderText = "Valoare Linie";
            colValoareLinie.Name = "colValoareLinie";
            colValoareLinie.DefaultCellStyle.Format = "C2";
            colValoareLinie.ReadOnly = true;
            dgvProduseTranzactie.Columns.Add(colValoareLinie);

            
        }


        private void ActualizeazaDgvProduseTranzactie()
        {
            dgvProduseTranzactie.Rows.Clear();
            foreach (ProdusTranzactie pt in produseInTranzactieCurenta)
            {
                
                int rowIndex = dgvProduseTranzactie.Rows.Add();
                DataGridViewRow row = dgvProduseTranzactie.Rows[rowIndex];

                row.Cells["colDenumire"].Value = pt.Produsul.Denumire;
                row.Cells["colCantitate"].Value = pt.CantitateVanduta;
                row.Cells["colPretUnitar"].Value = pt.PretLaMomentulVanzarii;
                row.Cells["colValoareLinie"].Value = pt.ValoareLinieTranzactie();
                row.Tag = pt; 
            }
        }


        private void btnAdaugaProdusInCos_Click(object sender, EventArgs e)
        {
            if (cmbProduseTranzactie.SelectedItem == null)
            {
                MessageBox.Show("Va rugam selectati un produs.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCantitateProdus.Text))
            {
                MessageBox.Show("Va rugam introduceti cantitatea.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCantitateProdus.Focus();
                return;
            }

            int cantitate;
            if (!int.TryParse(tbCantitateProdus.Text, out cantitate) || cantitate <= 0)
            {
                MessageBox.Show("Cantitatea trebuie sa fie un numar intreg pozitiv.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCantitateProdus.Focus();
                return;
            }

            Produs produsSelectat = (Produs)cmbProduseTranzactie.SelectedItem;

            if (produsSelectat.CantitateStoc < cantitate)
            {
                MessageBox.Show($"Stoc insuficient pentru {produsSelectat.Denumire}. Stoc disponibil: {produsSelectat.CantitateStoc}", "Stoc Insuficient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            ProdusTranzactie produsExistentInCos = produseInTranzactieCurenta.FirstOrDefault(p => p.Produsul.IdProdus == produsSelectat.IdProdus);

            if (produsExistentInCos != null)
            {
                
                if (produsSelectat.CantitateStoc < (produsExistentInCos.CantitateVanduta + cantitate))
                {
                    MessageBox.Show($"Stoc insuficient pentru a adauga inca {cantitate} buc. la {produsSelectat.Denumire}. Stoc disponibil: {produsSelectat.CantitateStoc}, deja in cos: {produsExistentInCos.CantitateVanduta}", "Stoc Insuficient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                produsExistentInCos.CantitateVanduta += cantitate;
            }
            else
            {
              
                ProdusTranzactie pt = new ProdusTranzactie(produsSelectat, cantitate);
                produseInTranzactieCurenta.Add(pt);
            }

           
            ActualizeazaDgvProduseTranzactie();
            ActualizeazaValoareTotala();
            tbCantitateProdus.Clear();
        }

        private void ActualizeazaValoareTotala()
        {
            double total = 0;
            foreach (ProdusTranzactie pt in produseInTranzactieCurenta)
            {
                total += pt.ValoareLinieTranzactie();
            }
            tbValoareTotalaTranzactie.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private int GenereazaIdTranzactieNou(List<Tranzactie> tranzactiiExistente)
        {
            if (tranzactiiExistente == null || tranzactiiExistente.Count == 0)
            {
                return 1;
            }
            else
            {
                return tranzactiiExistente.Max(t => t.TranzactieId) + 1;
            }
        }


        private void btnSalveazaTranzactie_Click(object sender, EventArgs e)
        {
            if (cmbClienti.SelectedItem == null)
            {
                MessageBox.Show("Va rugam selectati un client.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (produseInTranzactieCurenta.Count == 0)
            {
                MessageBox.Show("Tranzactia nu contine niciun produs.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client clientSelectat = (Client)cmbClienti.SelectedItem;
            DateTime dataSelectata = dtpDataTranzactie.Value;

           

            
            int idNouTranzactie = new Random().Next(1000, 9999); 

            TranzactieNoua = new Tranzactie(idNouTranzactie, dataSelectata, clientSelectat);
            foreach (ProdusTranzactie pt in produseInTranzactieCurenta)
            {
                
                TranzactieNoua += pt; 

            
                Produs produsDinStoc = listaProduseDisponibile.FirstOrDefault(p => p.IdProdus == pt.Produsul.IdProdus);
                if (produsDinStoc != null)
                {
                    produsDinStoc.CantitateStoc -= pt.CantitateVanduta;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuleazaTranzactie_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}