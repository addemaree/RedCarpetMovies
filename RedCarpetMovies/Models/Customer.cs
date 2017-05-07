using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedCarpetMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Your name is too long")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display (Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdaydate { get; set; }

    }
}