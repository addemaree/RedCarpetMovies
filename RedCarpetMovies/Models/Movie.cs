using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace RedCarpetMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "This name is too long.")]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}