using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    abstract class HeaKangelane:Kangelane
    {
        public HeaKangelane(string Nimi, string superNimi, string Voime) : base(Nimi, superNimi, Voime)
        {

        }

        private string KasutaVoimet()
        {
            return "Hea Kangelane " + AnnaSuperNimi + " päästab maailma.";
        }

    }
}
