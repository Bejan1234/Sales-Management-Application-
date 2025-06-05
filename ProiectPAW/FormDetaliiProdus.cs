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

namespace ProiectPAW 
{
    public partial class FormDetaliiProdus : Form
    {
        
        public Produs ProdusCurent { get; private set; }
        private bool modEditare = false;

        
        public FormDetaliiProdus()
        {
            InitializeComponent();
            modEditare = false;
            this.Text = "Adaugă Produs Nou";
            tbIdProdus.ReadOnly = true; 
        }

        
        public FormDetaliiProdus(Produs produsDeModificat)
        {
            InitializeComponent();
            modEditare = true;
            this.Text = "Modifică Detalii Produs";
            ProdusCurent = produsDeModificat;

            tbIdProdus.Text = produsDeModificat.IdProdus.ToString();
            tbIdProdus.ReadOnly = true;
            tbDenumire.Text = produsDeModificat.Denumire;
            tbPretUnitar.Text = produsDeModificat.PretUnitar.ToString(CultureInfo.InvariantCulture);
            tbCantitateStoc.Text = produsDeModificat.CantitateStoc.ToString();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(tbDenumire.Text))
            {
                MessageBox.Show("Denumirea produsului este obligatorie!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDenumire.Focus();
                return; 
            }

            double pret;
            if (!double.TryParse(tbPretUnitar.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out pret) || pret < 0)
            {
                MessageBox.Show("Prețul unitar trebuie să fie un număr pozitiv!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPretUnitar.Focus();
                return;
            }

            int stoc;
            if (!int.TryParse(tbCantitateStoc.Text, out stoc) || stoc < 0)
            {
                MessageBox.Show("Cantitatea în stoc trebuie să fie un număr întreg pozitiv!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCantitateStoc.Focus();
                return;
            }

            int id;
            
            if (!modEditare) 
            {
                if (string.IsNullOrWhiteSpace(tbIdProdus.Text) || !int.TryParse(tbIdProdus.Text, out id) || id <= 0)
                {
                   
                    if (!tbIdProdus.ReadOnly) 
                    {
                        if (!int.TryParse(tbIdProdus.Text, out id) || id <= 0)
                        {
                            MessageBox.Show("ID-ul produsului trebuie să fie un număr întreg pozitiv!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbIdProdus.Focus();
                            return;
                        }
                    }
                    else
                    {
                       
                        id = 0; 
                        if (!string.IsNullOrWhiteSpace(tbIdProdus.Text) && int.TryParse(tbIdProdus.Text, out int idParsed))
                        {
                            id = idParsed; 
                        }
                    }
                }
                else
                { 
                    id = Convert.ToInt32(tbIdProdus.Text);
                }
            }
            else 
            {
                id = ProdusCurent.IdProdus;
            }


            if (modEditare)
            {
                
                ProdusCurent.Denumire = tbDenumire.Text;
                ProdusCurent.PretUnitar = pret;
                ProdusCurent.CantitateStoc = stoc;
            }
            else
            {
               
                ProdusCurent = new Produs(id, tbDenumire.Text, pret, stoc);
            }

         
            this.DialogResult = DialogResult.OK;
           
        }
    }
}