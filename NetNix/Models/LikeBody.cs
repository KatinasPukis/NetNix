using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetNix.Models
{
    public class LikeBody
    {
       [Required] public string username { get; set; }
       [Required] public Guid movieId { get; set; }
    }
}