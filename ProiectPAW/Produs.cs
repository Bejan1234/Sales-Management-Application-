using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace ProiectPAW
{
    public class Produs : ICloneable, IComparable, IPersistentaText
    {
        private int idProdus;
        private string denumire;
        private double pretUnitar;
        private int cantitateStoc;

        public Produs()
        {
            this.idProdus = 0;
            this.denumire = "N/A";
            this.pretUnitar = 0.0;
            this.cantitateStoc = 0;
        }

        
        public Produs(int idProdus, string denumire, double pretUnitar, int cantitateStoc)
        {
            this.idProdus = idProdus;
            this.denumire = denumire;
            this.pretUnitar = pretUnitar;
            this.cantitateStoc = cantitateStoc;
        }

        public int IdProdus
        {
            get { return idProdus; }
            set { idProdus = value; } 
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; } 
        }

        public double PretUnitar
        {
            get { return pretUnitar; }
            set
            {
                if (value > 0) 
                    pretUnitar = value;
              
            }
        }

        public int CantitateStoc
        {
            get { return cantitateStoc; }
            set
            {
                if (value >= 0) 
                    cantitateStoc = value;
                
            }
        }

       
        public object Clone()
        {
           
        
            Produs clona = (Produs)this.MemberwiseClone();
           
            return clona;
        }

       
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Produs altProdus = obj as Produs;
            if (altProdus != null)
            {
                return this.denumire.CompareTo(altProdus.denumire);
            }
            else
            {
                throw new ArgumentException("Object is not a Produs");
            }
        }




      
        public static Produs operator +(Produs p, int cantitateAdaugata)
        {
            Produs rezultat = (Produs)p.Clone(); 
            rezultat.CantitateStoc += cantitateAdaugata;
            return rezultat;
        }

      
        public static Produs operator --(Produs p)
        {
            Produs rezultat = (Produs)p.Clone(); 
            if (rezultat.CantitateStoc > 0)
            {
                rezultat.CantitateStoc--;
            }
           
            return rezultat;
        }

      
        public static bool operator >(Produs p1, Produs p2)
        {
            if (p1 is null || p2 is null) return false; 
            return p1.PretUnitar > p2.PretUnitar;
        }

        public static bool operator <(Produs p1, Produs p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.PretUnitar < p2.PretUnitar;
        }

        public double CalculeazaValoareStoc()
        {
            return this.pretUnitar * this.cantitateStoc;
        }

        public void ActualizeazaPret(double procentajModificare)
        {
            
            this.PretUnitar *= (1 + procentajModificare);
        }
        

        public override string ToString()
        {
            return $"Produs ID: {idProdus}, Denumire: {denumire}, Pret: {pretUnitar:C}, Stoc: {cantitateStoc} buc.";
        }

        public string SerializeazaPentruFisierText()
        {
            
            return string.Format("{0},{1},{2},{3}",
                                 this.IdProdus,
                                 this.Denumire,
                                 this.PretUnitar.ToString(CultureInfo.InvariantCulture),
                                 this.CantitateStoc);
        }

        public void DeserializeazaDinLinieText(string linie)
        {
            if (string.IsNullOrWhiteSpace(linie))
            {
              
                return;
            }

            string[] parts = linie.Split(',');
            if (parts.Length >= 4) 
            {
                try
                {
                    this.IdProdus = Convert.ToInt32(parts[0]);
                    this.Denumire = parts[1];
                    
                    this.PretUnitar = Convert.ToDouble(parts[2], CultureInfo.InvariantCulture);
                    this.CantitateStoc = Convert.ToInt32(parts[3]);
                }
                catch (FormatException ex)
                {
                    
                    Console.WriteLine("Eroare la deserializarea produsului: Format invalid in linie - " + ex.Message);
                    
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Eroare la deserializarea produsului: Valoare prea mare/mica - " + ex.Message);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Eroare necunoscuta la deserializarea produsului - " + ex.Message);
                }
            }
            else
            {
              
                Console.WriteLine("Eroare la deserializarea produsului: Linia nu contine suficiente date.");
            }
        }

    }
}
