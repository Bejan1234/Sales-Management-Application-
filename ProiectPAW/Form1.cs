using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace ProiectPAW 
{
    public partial class Form1 : Form
    {
        private List<Produs> listaProdusePrincipala;
        private List<Client> listaClientiPrincipala;
        private List<Tranzactie> listaGlobalaTranzactii;

        private PrintDocument documentDePrintat;
        private List<string> liniiPentruPrint;

        
        private const string NUME_FISIER_PRODUSE = "produse.txt";
        private const string NUME_FISIER_CLIENTI = "clienti.txt";
        private const string NUME_FISIER_TRANZACTII = "tranzactii.txt";

        public Form1()
        {
            InitializeComponent();

            listaProdusePrincipala = new List<Produs>();
            listaClientiPrincipala = new List<Client>();
            listaGlobalaTranzactii = new List<Tranzactie>();

            IncarcaToateDatele();

          
            if (listaProdusePrincipala.Count == 0 && listaClientiPrincipala.Count == 0)
            {
                IncarcaDateTestInitiale(); 
            }
        }

    
        private void IncarcaDateTestInitiale()
        {
            listaProdusePrincipala.Add(new Produs(1, "Laptop Alpha", 3200.00, 5));
            listaProdusePrincipala.Add(new Produs(2, "Mouse Beta", 85.50, 15));
            listaClientiPrincipala.Add(new Client(1, "Popescu Ion", "0722000000", "popescu@email.com"));
            listaClientiPrincipala.Add(new Client(2, "Marinescu Eva", "0744000000", "eva.m@email.com"));
        }

      
        private void SalveazaProduse()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(NUME_FISIER_PRODUSE))
                {
                    foreach (Produs p in listaProdusePrincipala)
                    {
                        sw.WriteLine(p.SerializeazaPentruFisierText());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea produselor: " + ex.Message, "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalveazaClienti()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(NUME_FISIER_CLIENTI))
                {
                    foreach (Client c in listaClientiPrincipala)
                    {
                        sw.WriteLine(c.SerializeazaPentruFisierText());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea clientilor: " + ex.Message, "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalveazaTranzactii()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(NUME_FISIER_TRANZACTII))
                {
                    foreach (Tranzactie t in listaGlobalaTranzactii)
                    {
                        sw.WriteLine(t.SerializeazaPentruFisierText());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea tranzactiilor: " + ex.Message, "Eroare Salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalveazaToateDatele()
        {
            SalveazaProduse();
            SalveazaClienti();
            SalveazaTranzactii();
        }

      
        private void IncarcaProduse()
        {
            if (File.Exists(NUME_FISIER_PRODUSE))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(NUME_FISIER_PRODUSE))
                    {
                        string linie;
                        while ((linie = sr.ReadLine()) != null)
                        {
                            Produs p = new Produs(); 
                            p.DeserializeazaDinLinieText(linie);
                            if (p.IdProdus != 0) 
                            {
                                listaProdusePrincipala.Add(p);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la incarcarea produselor: " + ex.Message, "Eroare Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IncarcaClienti()
        {
            if (File.Exists(NUME_FISIER_CLIENTI))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(NUME_FISIER_CLIENTI))
                    {
                        string linie;
                        while ((linie = sr.ReadLine()) != null)
                        {
                            Client c = new Client();
                            c.DeserializeazaDinLinieText(linie);
                            if (c.ClientId != 0)
                            {
                                listaClientiPrincipala.Add(c);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la incarcarea clientilor: " + ex.Message, "Eroare Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IncarcaTranzactii()
        {
            if (File.Exists(NUME_FISIER_TRANZACTII))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(NUME_FISIER_TRANZACTII))
                    {
                        string linie;
                        while ((linie = sr.ReadLine()) != null)
                        {
                            Tranzactie t = new Tranzactie(); 
                            t.DeserializeazaDinLinieText(linie); 

                            if (t.TranzactieId != 0)
                            {
                                
                                if (t.ClientAsociat != null) 
                                {
                                    Client clientReal = listaClientiPrincipala.FirstOrDefault(c => c.ClientId == t.ClientAsociat.ClientId);
                                    t.ClientAsociat = clientReal; 
                                }

                                
                                List<ProdusTranzactie> produseTranzactieCuReferinteReale = new List<ProdusTranzactie>();
                                foreach (ProdusTranzactie ptPlaceholder in t) 
                                {
                                    if (ptPlaceholder.Produsul != null) 
                                    {
                                        Produs produsReal = listaProdusePrincipala.FirstOrDefault(p => p.IdProdus == ptPlaceholder.Produsul.IdProdus);
                                        if (produsReal != null)
                                        {
                                           
                                            ProdusTranzactie ptReal = new ProdusTranzactie(produsReal, ptPlaceholder.CantitateVanduta);
                                            ptReal.PretLaMomentulVanzarii = ptPlaceholder.PretLaMomentulVanzarii;
                                            produseTranzactieCuReferinteReale.Add(ptReal);
                                        }
                                    }
                                }
                               
                                Tranzactie tranzactieFinala = new Tranzactie(t.TranzactieId, t.DataTranzactie, t.ClientAsociat);
                                foreach (ProdusTranzactie ptReal in produseTranzactieCuReferinteReale)
                                {
                                    tranzactieFinala += ptReal; 
                                }
                                listaGlobalaTranzactii.Add(tranzactieFinala);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la incarcarea tranzactiilor: " + ex.Message, "Eroare Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void IncarcaToateDatele()
        {
            
            IncarcaProduse();
            IncarcaClienti();
            IncarcaTranzactii(); 
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            DialogResult raspuns = MessageBox.Show("Doriti sa salvati datele inainte de a inchide aplicatia?",
                                                 "Salvare Date",
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Question);

            if (raspuns == DialogResult.Yes)
            {
                SalveazaToateDatele();
                MessageBox.Show("Datele au fost salvate.", "Salvare finalizata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (raspuns == DialogResult.Cancel)
            {
                e.Cancel = true; 
            }
            
        }

     
        private int GenereazaIdTranzactieNoua()
        {
            if (listaGlobalaTranzactii.Count == 0)
            {
                return 1;
            }
            else
            {
                return listaGlobalaTranzactii.Max(t => t.TranzactieId) + 1;
            }
        }


        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduse formProduse = new FormProduse(listaProdusePrincipala);
            formProduse.ShowDialog();
          
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti(listaClientiPrincipala);
            formClienti.ShowDialog();
        }

        private void tranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaClientiPrincipala.Count == 0)
            {
                MessageBox.Show("Va rugam adaugati clienti pentru a putea crea o tranzactie.",
                                "Date insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listaProdusePrincipala.Where(p => p.CantitateStoc > 0).ToList().Count == 0) //Verificam daca avem produse cu stoc
            {
                MessageBox.Show("Nu exista produse disponibile in stoc pentru a crea o tranzactie.",
                                "Stoc epuizat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormTranzactii formTranzactii = new FormTranzactii(listaClientiPrincipala, listaProdusePrincipala);

            if (formTranzactii.ShowDialog() == DialogResult.OK)
            {
                if (formTranzactii.TranzactieNoua != null)
                {
                    Tranzactie tranzactieFinalizata = formTranzactii.TranzactieNoua;
                    tranzactieFinalizata.TranzactieId = GenereazaIdTranzactieNoua();
                    listaGlobalaTranzactii.Add(tranzactieFinalizata);

                    MessageBox.Show($"Tranzactie (ID: {tranzactieFinalizata.TranzactieId}) salvata cu succes! Valoare: {tranzactieFinalizata.ValoareTotala:C}",
                                    "Tranzactie Salvata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalveazaToateDatele();
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare manuală", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaProdusePrincipala.Clear();
            listaClientiPrincipala.Clear();
            listaGlobalaTranzactii.Clear();

            IncarcaToateDatele();
            MessageBox.Show("Datele au fost reîncărcate din fișiere!", "Încărcare manuală", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AfiseazaGraficValoareStoc()
        {
            FormGraficStocValoare f = new FormGraficStocValoare(listaProdusePrincipala);
            f.ShowDialog();
        }

        private void graficStocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfiseazaGraficValoareStoc(); // Aici se deschide graficul
        }
        private void PregatesteDatePentruPrint()
        {
            liniiPentruPrint = new List<string>();
            liniiPentruPrint.Add("LISTA PRODUSE DISPONIBILE");
            liniiPentruPrint.Add("----------------------------");

            foreach (var p in listaProdusePrincipala)
            {
                string linie = $"{p.Denumire,-25} | {p.PretUnitar,8:F2} RON | stoc: {p.CantitateStoc}";
                liniiPentruPrint.Add(linie);
            }
        }

        private void documentDePrintat_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Consolas", 12);
            float y = 100;
            float x = 50;
            float inaltimeRand = font.GetHeight(e.Graphics) + 5;

            foreach (string linie in liniiPentruPrint)
            {
                e.Graphics.DrawString(linie, font, Brushes.Black, x, y);
                y += inaltimeRand;
            }
        }

        private void AfiseazaPrevizualizarePrint()
        {
            PregatesteDatePentruPrint();

            documentDePrintat = new PrintDocument();
            documentDePrintat.PrintPage += new PrintPageEventHandler(documentDePrintat_PrintPage);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documentDePrintat;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void imprimareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfiseazaPrevizualizarePrint();
        }


    }
}