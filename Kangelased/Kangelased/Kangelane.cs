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

		public Kangelane(string Nimi, string Asukoht)
		{
			this.Nimi = Nimi;
			this.Asukoht = Asukoht;
		}
        public Kangelane(string superNimi, string Voime, string Nimi)
        {
            _superNimi = superNimi;
            _Voime = Voime;
            _Nimi = Nimi;
        }
        public string AnnaNimi
        {
            get => _Nimi;
        }
        public string AnnaSuperNimi
        {
            get => _superNimi;
        }
        public string AnnaVoime
        {
            get => _Voime;
        }
        public abstract void VoiduKone();

        interface ISuperVoime { }

        public string Nimi { get => _Nimi; set => _Nimi = value; }
		public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

		public virtual int Päästa(int Ohustatuid)
		{
			return (int)Math.Round(Ohustatuid * .95);
		}
		public override string ToString()
		{
			return Nimi + " hoiab " + Asukoht + " turvalisena.";
		}
	}
}
