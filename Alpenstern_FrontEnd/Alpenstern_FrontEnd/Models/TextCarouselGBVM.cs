using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpenstern_FrontEnd.Models
{
    public class TextCarouselGBVM
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string msg { get; set; }
        public List<TextCarouselGBVM> Liste { get; set; }

        public TextCarouselGBVM()
        {
            Liste = new List<TextCarouselGBVM>();
        }

    }
}