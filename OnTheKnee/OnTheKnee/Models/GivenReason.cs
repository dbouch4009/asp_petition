using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnTheKnee.Models
{
    public class GivenReason
    {
        public Guid Id { get; set; }

        [StringLength(3000)]
        public string GivenReasonDetail { get; set; }
    }
}