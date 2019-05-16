using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class HeaKangelane:Kangelane
    {
        public HeaKangelane(string Nimi, string superNimi, string Voime) : base(Nimi, superNimi, Voime)
        {

        }

        public override void KasutaVoimet()
        {
            Console.WriteLine($"heakangelane { AnnaSuperNimi()} proovib päästa maailma");
        }
        public override void VoiduKone()
        {
            Console.WriteLine("Ärge muretsege, ma päästan teid kõiki alati.");
        }
       
    

    }
}
