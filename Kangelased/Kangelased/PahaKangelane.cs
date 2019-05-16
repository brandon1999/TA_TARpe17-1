using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
     class PahaKangelane:Kangelane
    {
        public PahaKangelane(string Nimi, string superNimi, string Voime) : base(Nimi, superNimi, Voime)
        {
        }
        public string KasutaVoimet()
        {
            return "paha Kangelane " + AnnaSuperNimi() + " püüab hävitada maailma.";
        }
        public override void VoiduKone()
        {

        }
    }
}
