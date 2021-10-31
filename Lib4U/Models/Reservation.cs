using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lib4U.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime ReservedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }

    }

    public class ReservationNewViewModel
    {        
        [Display(Name = "Student")]
        public int ReaderId { get; set; }                       

        public DateTime ReservedDate { get; set; }
        public DateTime DueDate { get; set; }        

        public List<Book> SelectedBooks { get; set; }
        public IEnumerable<Book> AvailableBooks { get; set; }
        public IEnumerable<Reader> Readers { get; set; }
    }
}