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
        public override void KasutaVoimet()
        {
            Console.WriteLine($"Paha kangelane { AnnaSuperNimi()} püüab hävitada maailma");
        }
        public override void VoiduKone()
        {
            Console.WriteLine("Keegi pole minust tugevam ja kurjem.");
        }
    }
}
