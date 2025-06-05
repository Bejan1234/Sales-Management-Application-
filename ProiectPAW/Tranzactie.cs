using ProiectPAW;
using System;
using System.Collections; 
using System.Collections.Generic;
using System.Globalization; 
using System.Linq; 

namespace ProiectPAW 
{
   
    public class Tranzactie : IEnumerable, IPersistentaText
    {
        private int tranzactieId;
        private DateTime dataTranzactie;
        private Client clientAsociat;
        private List<ProdusTranzactie> produseVandute;

        public int TranzactieId
        {
            get { return tranzactieId; }
            set { tranzactieId = value; }
        }

        public DateTime DataTranzactie
        {
            get { return dataTranzactie; }
            set { dataTranzactie = value; }
        }

        public Client ClientAsociat
        {
            get { return clientAsociat; }
            set { clientAsociat = value; }
        }

        public int NumarProduseDistincte
        {
            get { return produseVandute.Count; }
        }

        public double ValoareTotala
        {
            get
            {
                double total = 0;
                foreach (ProdusTranzactie pt in produseVandute)
                {
                    total += pt.ValoareLinieTranzactie();
                }
                return total;
            }
        }

        // Constructori
        public Tranzactie(int tranzactieId, Client client)
        {
            this.tranzactieId = tranzactieId;
            this.dataTranzactie = DateTime.Now;
            this.clientAsociat = client;
            this.produseVandute = new List<ProdusTranzactie>();
        }

        public Tranzactie(int tranzactieId, DateTime data, Client client)
        {
            this.tranzactieId = tranzactieId;
            this.dataTranzactie = data;
            this.clientAsociat = client;
            this.produseVandute = new List<ProdusTranzactie>();
        }

        public Tranzactie()
        {
            this.produseVandute = new List<ProdusTranzactie>();
            this.dataTranzactie = DateTime.MinValue; 
        }


        // Indexator
        public ProdusTranzactie this[int index]
        {
            get
            {
                if (index >= 0 && index < produseVandute.Count)
                {
                    return produseVandute[index];
                }
                throw new IndexOutOfRangeException("Indexul este in afara limitelor listei de produse vandute.");
            }
        }

        // Implementare IEnumerable
        public IEnumerator GetEnumerator()
        {
            return produseVandute.GetEnumerator();
        }

        // Operatori supraincarcati
        public static Tranzactie operator +(Tranzactie t, ProdusTranzactie pt)
        {
            ProdusTranzactie existent = t.produseVandute.Find(item => item.Produsul.IdProdus == pt.Produsul.IdProdus);
            if (existent != null)
            {
                existent.CantitateVanduta += pt.CantitateVanduta;
            }
            else
            {
                t.produseVandute.Add(pt);
            }
            return t;
        }

        public static explicit operator double(Tranzactie t)
        {
            return t.ValoareTotala;
        }

        // Metode de prelucrare date
        public void AdaugaProdusInTranzactie(Produs p, int cantitate)
        {
            if (p == null || cantitate <= 0)
            {
                Console.WriteLine("Produs invalid sau cantitate invalida.");
                return;
            }
            ProdusTranzactie pt = new ProdusTranzactie(p, cantitate);
            ProdusTranzactie existent = produseVandute.Find(item => item.Produsul.IdProdus == p.IdProdus);
            if (existent != null)
            {
                existent.CantitateVanduta += cantitate;
            }
            else
            {
                produseVandute.Add(pt);
            }
        }

        public void StergeProdusDinTranzactie(int idProdus)
        {
            ProdusTranzactie deSters = produseVandute.Find(pt => pt.Produsul.IdProdus == idProdus);
            if (deSters != null)
            {
                produseVandute.Remove(deSters);
            }
        }

        // Suprascriere ToString
        public override string ToString()
        {
            string detaliiProduse = "";
            foreach (ProdusTranzactie pt in produseVandute)
            {
                detaliiProduse += "\n   - " + pt.ToString();
            }

            return string.Format("Tranzactie ID: {0}, Data: {1}, Client: {2}, Valoare Totala: {3:C}, Produse: {4}",
                                 tranzactieId,
                                 dataTranzactie.ToShortDateString(),
                                 (clientAsociat != null ? clientAsociat.NumeClient : "N/A"),
                                 ValoareTotala,
                                 (string.IsNullOrEmpty(detaliiProduse) ? "Niciun produs" : detaliiProduse));
        }

        // Implementarea metodei SerializeazaPentruFisierText din IPersistentaText
        public string SerializeazaPentruFisierText()
        {
            string dataFormatata = this.DataTranzactie.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            int clientIdPentruSalvare = (this.ClientAsociat != null) ? this.ClientAsociat.ClientId : 0;

            List<string> produseSerializate = new List<string>();
            foreach (ProdusTranzactie pt in this.produseVandute)
            {
                if (pt.Produsul != null)
                {
                    produseSerializate.Add(string.Format("{0}:{1}:{2}",
                                                         pt.Produsul.IdProdus,
                                                         pt.CantitateVanduta,
                                                         pt.PretLaMomentulVanzarii.ToString(CultureInfo.InvariantCulture)));
                }
            }
            string produseConcatenate = string.Join(";", produseSerializate);

            return string.Format("{0},{1},{2},[{3}]",
                                 this.TranzactieId,
                                 dataFormatata,
                                 clientIdPentruSalvare,
                                 produseConcatenate);
        }

        // Implementarea metodei DeserializeazaDinLinieText din IPersistentaText
        public void DeserializeazaDinLinieText(string linie)
        {
            if (string.IsNullOrWhiteSpace(linie)) return;

            string[] parts = linie.Split(new[] { ',' }, 4);
            if (parts.Length >= 4)
            {
                try
                {
                    this.TranzactieId = Convert.ToInt32(parts[0]);
                    this.DataTranzactie = DateTime.ParseExact(parts[1], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                    int clientId = Convert.ToInt32(parts[2]);
                    this.ClientAsociat = new Client { ClientId = clientId }; 

                    this.produseVandute = new List<ProdusTranzactie>(); 
                    string produseInfo = parts[3];
                    if (produseInfo.StartsWith("[") && produseInfo.EndsWith("]"))
                    {
                        produseInfo = produseInfo.Substring(1, produseInfo.Length - 2);
                        if (!string.IsNullOrEmpty(produseInfo))
                        {
                            string[] itemProduse = produseInfo.Split(';');
                            foreach (string item in itemProduse)
                            {
                                string[] detaliiProdus = item.Split(':');
                                if (detaliiProdus.Length >= 3)
                                {
                                    int idProdus = Convert.ToInt32(detaliiProdus[0]);
                                    int cantitate = Convert.ToInt32(detaliiProdus[1]);
                                    double pretVanzare = Convert.ToDouble(detaliiProdus[2], CultureInfo.InvariantCulture);

                                    Produs produsPlaceholder = new Produs { IdProdus = idProdus };
                                    this.produseVandute.Add(new ProdusTranzactie(produsPlaceholder, cantitate)
                                    { PretLaMomentulVanzarii = pretVanzare });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la deserializarea tranzactiei: " + ex.Message + " pe linia: " + linie);
                }
            }
            else
            {
                Console.WriteLine("Eroare la deserializarea tranzactiei: Linia nu contine suficiente date - " + linie);
            }
        }
    }
}