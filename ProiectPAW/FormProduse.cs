using ProiectPAW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW 
{
    public partial class FormProduse : Form
    {
      
        private List<Produs> listaProduseReferinta;

        
        public FormProduse(List<Produs> produseSursa)
        {
            InitializeComponent();

            
            listaProduseReferinta = produseSursa;

          
            dgvProduse.ReadOnly = true;
            dgvProduse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduse.MultiSelect = false;
            dgvProduse.AllowUserToAddRows = false;
            dgvProduse.AllowUserToDeleteRows = false;

            PopuleazaDataGridView();
        }

        

        private void PopuleazaDataGridView()
        {
            dgvProduse.DataSource = null;
            dgvProduse.DataSource = listaProduseReferinta;

            if (dgvProduse.Columns.Count > 0)
            {
                if (dgvProduse.Columns["IdProdus"] != null)
                {
                    dgvProduse.Columns["IdProdus"].HeaderText = "Cod Produs";
                }
                if (dgvProduse.Columns["Denumire"] != null)
                {
                    dgvProduse.Columns["Denumire"].HeaderText = "Denumire Produs";
                    dgvProduse.Columns["Denumire"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (dgvProduse.Columns["PretUnitar"] != null)
                {
                    dgvProduse.Columns["PretUnitar"].HeaderText = "Pret Unitar (RON)";
                    dgvProduse.Columns["PretUnitar"].DefaultCellStyle.Format = "C2";
                }
                if (dgvProduse.Columns["CantitateStoc"] != null)
                {
                    dgvProduse.Columns["CantitateStoc"].HeaderText = "Stoc Disponibil";
                }
            }
        }

        private int GenereazaIdProdusNou()
        {
           
            if (listaProduseReferinta.Count == 0)
            {
                return 1;
            }
            else
            {
                return listaProduseReferinta.Max(p => p.IdProdus) + 1;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormDetaliiProdus formDetalii = new FormDetaliiProdus();

            if (formDetalii.ShowDialog() == DialogResult.OK)
            {
                if (formDetalii.ProdusCurent != null)
                {
                    Produs produsNou = formDetalii.ProdusCurent;

                    if (produsNou.IdProdus == 0)
                    {
                        produsNou.IdProdus = GenereazaIdProdusNou();
                    }

                 
                    listaProduseReferinta.Add(produsNou);
                    PopuleazaDataGridView();
                    MessageBox.Show("Produs adaugat cu succes!", "Adaugare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count > 0)
            {
                Produs produsSelectat = (Produs)dgvProduse.SelectedRows[0].DataBoundItem;

                FormDetaliiProdus formDetalii = new FormDetaliiProdus(produsSelectat);

                if (formDetalii.ShowDialog() == DialogResult.OK)
                {
             
                    PopuleazaDataGridView();
                    MessageBox.Show("Produs modificat cu succes!", "Modificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un produs pentru a-l modifica.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count > 0)
            {
                Produs produsSelectat = (Produs)dgvProduse.SelectedRows[0].DataBoundItem;
                DialogResult rezultat = MessageBox.Show($"Sunteti sigur ca doriti sa stergeti produsul '{produsSelectat.Denumire}'?",
                                                      "Confirmare Stergere",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes)
                {
               
                    listaProduseReferinta.Remove(produsSelectat);
                    PopuleazaDataGridView();
                    MessageBox.Show($"Produsul '{produsSelectat.Denumire}' a fost sters.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un produs pentru a-l sterge.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            PopuleazaDataGridView();
            MessageBox.Show("Lista a fost actualizata.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modificaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModifica_Click(sender, e); 
        }

        private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStergeProdus_Click(sender, e); 
        }

        private void detaliiProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count > 0)
            {
                Produs produs = (Produs)dgvProduse.SelectedRows[0].DataBoundItem;
                MessageBox.Show(produs.ToString(), "Detalii produs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selectează un produs din listă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}