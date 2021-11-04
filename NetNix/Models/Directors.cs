using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetNix.Models
{
    public class Directors
    {
        [Required] public string name { get; set; }
        public string dateOfBirth { get; set; }

    }
}