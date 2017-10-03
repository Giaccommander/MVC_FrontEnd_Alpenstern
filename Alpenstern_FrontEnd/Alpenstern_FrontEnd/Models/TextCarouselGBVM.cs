using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpenstern_FrontEnd.Models
{
    public class TextCarouselGBVM
    {

        [StringLength(50, ErrorMessage = "Vorname ist zu lang!", MinimumLength = 5)]
        public string name { get; set; }

        [StringLength(50, ErrorMessage = "Nachname ist zu lang!", MinimumLength = 5)]
        public string surname { get; set; }

        [StringLength(350, ErrorMessage = "Ihre Nachricht ist zu kurz", MinimumLength = 5)]
        public string msg { get; set; }

        public List<TextCarouselGBVM> Liste { get; set; }

        public TextCarouselGBVM()
        {
            Liste = new List<TextCarouselGBVM>();
        }

    }
}