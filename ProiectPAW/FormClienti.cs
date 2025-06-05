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
    public partial class FormClienti : Form
    {
        private List<Client> listaClientiReferinta;

        public FormClienti(List<Client> clientiSursa)
        {
            InitializeComponent();
            listaClientiReferinta = clientiSursa;

            dgvClienti.ReadOnly = true;
            dgvClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienti.MultiSelect = false;
            dgvClienti.AllowUserToAddRows = false;
            dgvClienti.AllowUserToDeleteRows = false;

            PopuleazaDataGridViewClienti();
        }

        private void PopuleazaDataGridViewClienti()
        {
            dgvClienti.DataSource = null;
            dgvClienti.DataSource = listaClientiReferinta;

            if (dgvClienti.Columns.Count > 0)
            {
                if (dgvClienti.Columns["ClientId"] != null)
                {
                    dgvClienti.Columns["ClientId"].HeaderText = "Cod Client";
                }
                if (dgvClienti.Columns["NumeClient"] != null)
                {
                    dgvClienti.Columns["NumeClient"].HeaderText = "Nume Client";
                    dgvClienti.Columns["NumeClient"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (dgvClienti.Columns["NumarTelefon"] != null)
                {
                    dgvClienti.Columns["NumarTelefon"].HeaderText = "Telefon";
                }
                if (dgvClienti.Columns["AdresaEmail"] != null)
                {
                    dgvClienti.Columns["AdresaEmail"].HeaderText = "Email";
                    dgvClienti.Columns["AdresaEmail"].Width = 180;
                }
                if (dgvClienti.Columns["CodFiscal"] != null)
                {
                    dgvClienti.Columns["CodFiscal"].HeaderText = "Cod Fiscal";
                }
            }
        }

        private int GenereazaIdClientNou()
        {
            if (listaClientiReferinta.Count == 0)
            {
                return 1;
            }
            else
            {
                return listaClientiReferinta.Max(c => c.ClientId) + 1;
            }
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            FormDetaliiClient formDetalii = new FormDetaliiClient();
            if (formDetalii.ShowDialog() == DialogResult.OK)
            {
                if (formDetalii.ClientCurent != null)
                {
                    Client clientNou = formDetalii.ClientCurent;
                    if (clientNou.ClientId == 0)
                    {
                        clientNou.ClientId = GenereazaIdClientNou();
                    }
                    listaClientiReferinta.Add(clientNou);
                    PopuleazaDataGridViewClienti();
                    MessageBox.Show("Client adaugat cu succes!", "Adaugare Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModificaClient_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count > 0)
            {
                Client clientSelectat = (Client)dgvClienti.SelectedRows[0].DataBoundItem;
                FormDetaliiClient formDetalii = new FormDetaliiClient(clientSelectat);
                if (formDetalii.ShowDialog() == DialogResult.OK)
                {
                    PopuleazaDataGridViewClienti();
                    MessageBox.Show("Client modificat cu succes!", "Modificare Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un client pentru a-l modifica.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStergeClient_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count > 0)
            {
                Client clientSelectat = (Client)dgvClienti.SelectedRows[0].DataBoundItem;
                DialogResult rezultat = MessageBox.Show($"Sunteti sigur ca doriti sa stergeti clientul '{clientSelectat.NumeClient}'?",
                                                      "Confirmare Stergere",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes)
                {
                    listaClientiReferinta.Remove(clientSelectat);
                    PopuleazaDataGridViewClienti();
                    MessageBox.Show($"Clientul '{clientSelectat.NumeClient}' a fost sters.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un client pentru a-l sterge.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizeazaListaClienti_Click(object sender, EventArgs e)
        {
            PopuleazaDataGridViewClienti();
            MessageBox.Show("Lista de clienti a fost actualizata.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}