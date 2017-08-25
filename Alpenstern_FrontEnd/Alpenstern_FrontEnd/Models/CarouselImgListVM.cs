using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpenstern_FrontEnd.Models
{
	public class CarouselImgListVM
	{
		public List<CarouselImgVM> list;

		public CarouselImgListVM(List<CarouselImgVM> list)
		{
			this.list = list;
		}
	}
}