using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TauraForexWebSite.Models
{
    public class ContactUsViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string Fullname { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}