using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Client : ICloneable, IComparable,IPersistentaText
    {
        private int clientId;
        private string numeClient;
        private string codFiscal; 
        private string numarTelefon;
        private string adresaEmail;

      
        public Client()
        {
            this.clientId = 0;
            this.numeClient = "N/A";
            this.codFiscal = "N/A";
            this.numarTelefon = "N/A";
            this.adresaEmail = "N/A";
        }

        public Client(int clientId, string numeClient, string numarTelefon, string adresaEmail, string codFiscal = "N/A")
        {
            this.clientId = clientId;
            this.numeClient = numeClient;
            this.numarTelefon = numarTelefon;
            this.adresaEmail = adresaEmail;
            this.codFiscal = codFiscal;
        }
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public string NumeClient
        {
            get { return numeClient; }
            set { numeClient = value; } 
        }

        public string CodFiscal
        {
            get { return codFiscal; }
            set { codFiscal = value; }
        }

        public string NumarTelefon
        {
            get { return numarTelefon; }
            set { numarTelefon = value; } 
        }

        public string AdresaEmail
        {
            get { return adresaEmail; }
            set { adresaEmail = value; } 
        }

        public object Clone()
        {
         
            return this.MemberwiseClone();
        }

     
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Client altClient = obj as Client;
            if (altClient != null)
            {
                return this.numeClient.CompareTo(altClient.numeClient);
            }
            else
            {
                throw new ArgumentException("Obiectul nu este de tip Client");
            }
        }

      
        public static bool operator ==(Client c1, Client c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }
            if (c1 is null || c2 is null) 
            {
                return false;
            }
            return c1.ClientId == c2.ClientId;
        }

        public static bool operator !=(Client c1, Client c2)
        {
            return !(c1 == c2);
        }

       
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Client altClient = (Client)obj;
            return this.ClientId == altClient.ClientId;
        }

        public override int GetHashCode()
        {
            return this.ClientId.GetHashCode();
        }

        public static Client operator ++(Client c)
        {
            Client rezultat = (Client)c.Clone();
            rezultat.NumeClient = "VIP-" + rezultat.NumeClient;
            return rezultat;
        }

       

        public bool EsteEmailValid()
        {
        
            return !string.IsNullOrWhiteSpace(this.adresaEmail) && this.adresaEmail.Contains("@");
        }

        public string GenereazaSalut()
        {
            return $"Salut, {this.numeClient}!";


        }
        

        public override string ToString()
        {
            return $"Client ID: {clientId}, Nume: {numeClient}, Telefon: {numarTelefon}, Email: {adresaEmail}, Cod Fiscal: {codFiscal ?? "N/A"}";
        }



        public string SerializeazaPentruFisierText()
        {
            string codFiscalPentruSalvare = string.IsNullOrEmpty(this.CodFiscal) ? "N/A" : this.CodFiscal;

            return string.Format("{0},{1},{2},{3},{4}",
                                 this.ClientId,
                                 this.NumeClient,
                                 this.NumarTelefon,
                                 this.AdresaEmail,
                                 codFiscalPentruSalvare);
        }

        
        public void DeserializeazaDinLinieText(string linie)
        {
            if (string.IsNullOrWhiteSpace(linie))
            {
                return;
            }

            string[] parts = linie.Split(',');
            if (parts.Length >= 5) 
            {
                try
                {
                    this.ClientId = Convert.ToInt32(parts[0]);
                    this.NumeClient = parts[1];
                    this.NumarTelefon = parts[2];
                    this.AdresaEmail = parts[3];
                    
                    this.CodFiscal = (parts[4] == "N/A" || string.IsNullOrEmpty(parts[4])) ? null : parts[4];
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Eroare la deserializarea clientului: Format invalid in linie - " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Eroare la deserializarea clientului: Valoare prea mare/mica - " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare necunoscuta la deserializarea clientului - " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Eroare la deserializarea clientului: Linia nu contine suficiente date.");
            }
        }

    }
}
