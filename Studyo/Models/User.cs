using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Studyo.Models;

    public class User : IdentityUser
    {
        public List<Inquiry> Inquiries { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, ErrorMessage = "The Minimum length is {1} and the maximum is {2}")]
        public new string password { get; set; }

        [Required(ErrorMessage = "Valid Mobile Number is required")]
        [StringLength(11, ErrorMessage = "The Required Length is 11")]
        public string mobileNumber { get; set; }
        
        public DateTime dateCreated { get; set; }

    }
