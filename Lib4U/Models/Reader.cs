using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lib4U.Models
{
    public class Reader
    {        
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string MobilePhone { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public class ReaderCreateViewModel
    {        
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]        
        public string Address { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Phone]
        [Required]
        [Display(Name = "Phone Number")]
        public string MobilePhone { get; set; }
    }

    public class ReaderEditViewModel
    {
        public int Id { get; set; }
      
        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Phone]
        [Required]
        [Display(Name = "Phone Number")]
        public string MobilePhone { get; set; }
    }
}