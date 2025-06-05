using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace ProiectPAW
{
    public partial class FormDetaliiClient : Form
    {
        public Client ClientCurent { get; private set; }
        private bool modEditare = false;

    
        public FormDetaliiClient()
        {
            InitializeComponent();
            modEditare = false;
            this.Text = "Adauga Client Nou";
            tbClientId.ReadOnly = true;
            
        }

      
        public FormDetaliiClient(Client clientDeModificat)
        {
            InitializeComponent();
            modEditare = true;
            this.Text = "Modifica Detalii Client";
            ClientCurent = clientDeModificat;

            tbClientId.Text = clientDeModificat.ClientId.ToString();
            tbClientId.ReadOnly = true;
            tbNumeClient.Text = clientDeModificat.NumeClient;
            tbNumarTelefon.Text = clientDeModificat.NumarTelefon;
            tbAdresaEmail.Text = clientDeModificat.AdresaEmail;
            tbCodFiscal.Text = clientDeModificat.CodFiscal;
        }

        private void btnSalveazaClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumeClient.Text))
            {
                MessageBox.Show("Numele clientului este obligatoriu!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumeClient.Focus();
                return;
            }

         
            if (!string.IsNullOrWhiteSpace(tbAdresaEmail.Text) && !tbAdresaEmail.Text.Contains("@"))
            {
                MessageBox.Show("Adresa de email nu este valida!", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAdresaEmail.Focus();
                return;
            }

            int idClientPentruSalvare;
            if (modEditare)
            {
                idClientPentruSalvare = ClientCurent.ClientId;
                ClientCurent.NumeClient = tbNumeClient.Text;
                ClientCurent.NumarTelefon = tbNumarTelefon.Text;
                ClientCurent.AdresaEmail = tbAdresaEmail.Text;
                ClientCurent.CodFiscal = tbCodFiscal.Text; 
            }
            else
            {
               
                idClientPentruSalvare = 0; 

                ClientCurent = new Client(idClientPentruSalvare,
                                          tbNumeClient.Text,
                                          tbNumarTelefon.Text,
                                          tbAdresaEmail.Text,
                                          tbCodFiscal.Text);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void lblClientId_Click(object sender, EventArgs e)
        {

        }
    }
}