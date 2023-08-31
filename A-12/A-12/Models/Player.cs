using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using static System.Web.Razor.Parser.SyntaxConstants;
using System.Web.Mvc;
using System.Xml.Linq;

namespace A_12.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }
        [Required]
        public string Position { get; set; }

        [Required]
        public string Team { get; set; }
    }
}
    