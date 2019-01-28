using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnTheKnee.Models
{
    public class Community
    {
        public Guid Id { get; set; }

        [StringLength(255)]
        public string CommunityName { get; set; }
    }
}