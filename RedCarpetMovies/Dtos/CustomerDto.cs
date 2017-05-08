using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RedCarpetMovies.Models;

namespace RedCarpetMovies.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Your name is too long")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        
       // [Min18YearsIfAMember]
        public DateTime? Birthdaydate { get; set; }
    }
}