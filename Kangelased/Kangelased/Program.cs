using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Program
	{
		static List<Kangelane> Kangelased=new List<Kangelane>();
		static void LaeKangelased(string Failinimi)
		{
			string[] failiAndmed = System.IO.File.ReadAllLines(Failinimi);
			for (int i = 0; i < failiAndmed.Length; i++)
			{
				string[] nimiKoht = failiAndmed[i].Split(new char[] { '/' });
				string nimi = nimiKoht[0].Trim();
				string asukoht = nimiKoht[1].Trim();
				if (nimi.EndsWith("*"))
				{
					Kangelased.Add(new SuperKangelane(nimi.Trim(new char[] { '*' }), asukoht));
				}
				else
				{
					// Kangelased.Add(new Kangelane(nimi, asukoht));
				}
			}
		}
		static void Main(string[] args)
		{
            HeaKangelane batman = new HeaKangelane("batman", "SuperBatman", "surematu");
            Console.WriteLine(batman.KasutaVoimet());
            PahaKangelane joker = new PahaKangelane("joker", "superJoke", "nähtamatu");
            Console.WriteLine(joker.KasutaVoimet());
            Console.WriteLine(batman.Päästa(1000));
            Console.WriteLine(joker.Päästa(1000));
            
		}
	}
}
