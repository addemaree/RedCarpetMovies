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

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

       
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}