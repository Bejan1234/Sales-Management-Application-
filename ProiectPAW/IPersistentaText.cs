using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public interface IPersistentaText
    {
        string SerializeazaPentruFisierText();
        void DeserializeazaDinLinieText(string linie);
    }
}
