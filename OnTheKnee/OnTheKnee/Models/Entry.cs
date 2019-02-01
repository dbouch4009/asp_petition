using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnTheKnee.Models
{
    public class Entry
    {
        [Required]
        public Guid EntryId { get; set; }

        [Required]
        public Guid PersonId { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        public Guid GivenReasonId { get; set; }

        public Guid CommunityId { get; set; }

    }
}