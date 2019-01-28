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
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        [StringLength(3000)]
        public string GivenReasonDetail { get; set; }

        public Guid CommunityId { get; set; }

        public bool ShowPublicly { get; set; }
    }
}