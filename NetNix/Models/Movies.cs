using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetNix.Models
{
    public class Movies
    {
       [Required] public Guid Id { get; set; }
       [Required] public string Name { get; set; }
       [Required] public string releaseDate { get; set; }
        public string shortDescription { get; set; }
        public string description { get; set; }
        public string image { get; set; }
       [Required] public Directors director { get; set; }
    }
}