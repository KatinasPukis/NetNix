using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetNix.Models
{
    public class Likes
    {
        public Guid movieId { get; set; }
        public float like { get; set; }

    }
}