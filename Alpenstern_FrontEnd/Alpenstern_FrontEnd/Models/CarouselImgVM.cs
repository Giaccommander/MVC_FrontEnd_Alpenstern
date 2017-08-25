using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpenstern_FrontEnd.Models
{
	public class CarouselImgVM
	{
		public int id { get; set; }
		public string bilderart { get; set; }
		public string pfad { get; set; }

		public CarouselImgVM(int id, string bilderart, string pfad)
		{

			this.id = id;
			this.bilderart = bilderart;
			this.pfad = pfad;
		}
	}
}