﻿using System;
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

        public string KasutaVoimet()
        {
            return "Hea Kangelane " + AnnaSuperNimi() + " päästab maailma";
        }
        public override void VoiduKone()
        {
            
        }
       
    

    }
}
