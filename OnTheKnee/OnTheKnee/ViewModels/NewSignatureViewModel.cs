using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnTheKnee.ViewModels
{
    public class NewSignatureViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        [StringLength(3000)]
        [Display(Name = "Why do you want a Latin Mass? (optional)")]
        public string GivenReasonDetail { get; set; }

        public Guid CommunityId { get; set; }

        [Display(Name = "Show Publicly?")]
        public bool ShowPublicly { get; set; }
    }
}