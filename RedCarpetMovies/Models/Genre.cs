using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedCarpetMovies.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "This is too long")]
        public string Name { get; set; }

    }
}