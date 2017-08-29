using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpenstern_FrontEnd.Models
{
	public class KategorieVM
	{
		public int id { get; set; }
		public string bezeichnung { get; set; }
		public decimal preis { get; set; }
		public int personenAnzahl { get; set; }
		public int groesse { get; set; }

		public KategorieVM(int id, string bezeichnung, decimal preis, int personenAnzahl, int groesse)
		{
			this.id = id;
			this.bezeichnung = bezeichnung;
			this.preis = preis;
			this.personenAnzahl = personenAnzahl;
			this.groesse = groesse;
		}
	}
}