using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnTheKnee.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        [StringLength(255)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [Display(Name = "Show Publicly")]
        public bool ShowPublicly { get; set; }
    }
}