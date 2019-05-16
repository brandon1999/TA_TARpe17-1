using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	abstract class Kangelane
	{
		private string _Nimi;
		private string _Asukoht;
        private string _superNimi;
        private string _Voime;
        private double _Osavus;

		public Kangelane(string Nimi, string Asukoht)
		{
			this.Nimi = Nimi;
			this.Asukoht = Asukoht;
		}
        public Kangelane(string Nimi, string superNimi, string Voime)
        {
            _superNimi = superNimi;
            _Voime = Voime;
            _Nimi = Nimi;
        }
        public string AnnaNimi()
        {
            return _Nimi;
        }
        public string AnnaSuperNimi()
        {
            return _superNimi;
        }
        public string AnnaVoime()
        {
            return _Voime;
        }
        public abstract void VoiduKone();
 
       

        public string Nimi { get => _Nimi; set => _Nimi = value; }
		public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

        virtual public int Päästa(int ohustatuid)
        {
            return (int)Math.Round(ohustatuid * .95);
        }
        public override string ToString()
		{
			return Nimi + " hoiab " + Asukoht + " turvalisena.";
		}
        public int rynnak()
        {
            Random r = new Random();
            return r.Next();
        }
	}
}
