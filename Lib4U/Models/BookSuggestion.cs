using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lib4U.Models
{
    public class BookSuggestion
    {
        public int Id { get; set; }

        [Required]
        public string Author { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Display(Name = "Publishcation Date")]
        public DateTime PublishcationDate { get; set; }

        [Display(Name = "Reason For Suggestion")]
        public string ReasonForSuggestion { get; set; }
        
    }    

}