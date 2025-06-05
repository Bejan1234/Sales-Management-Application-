using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class ProdusTranzactie
    {
        public Produs Produsul { get; set; }
        public int CantitateVanduta { get; set; }
        public double PretLaMomentulVanzarii { get; set; } 


        public ProdusTranzactie(Produs produsul, int cantitateVanduta)
        {
            this.Produsul = produsul;
            this.CantitateVanduta = cantitateVanduta;
            this.PretLaMomentulVanzarii = produsul.PretUnitar; 

        }

        public double ValoareLinieTranzactie()
        {
            return CantitateVanduta * PretLaMomentulVanzarii;
        }

        public override string ToString()
        {
            return $"Produs: {Produsul.Denumire}, Cantitate: {CantitateVanduta}, Pret Unitar: {PretLaMomentulVanzarii:C}, Valoare: {ValoareLinieTranzactie():C}";
        }
    }
}
