
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
        public virtual Reader Reader { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        [Display(Name = "Reserved Date")]
        public DateTime ReservedDate { get; set; }
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Confirmed Date")]
        public DateTime? ConfirmedDate { get; set; }
        [Display(Name = "Returned Date")]
        public DateTime? ReturnedDate { get; set; }

    }

    public class ReservationListViewModel
    {
        public Reservation Reservation;
        public string StudentName
        {
            get => Reservation.Reader.FirstName + " " + Reservation.Reader.LastName + " " + Reservation.Reader.User.Email;
        }

    }

    public class ReservationListEmail
    {
        public Reservation Reservation;
        public string StudentMail
        {
            get => Reservation.Reader.User.Email;
        }

    }

    public class ReservationNewViewModel
    {        
        [Display(Name = "Student")]
        [Required]
        public int ReaderId { get; set; }                       

        public DateTime ReservedDate { get; set; }
        public DateTime DueDate { get; set; }        

        [ListHasElements(ErrorMessage = "There is no book")]
        [Required]
        public List<int> SelectedBooks { get; set; }
        public IEnumerable<Book> AvailableBooks { get; set; }
        public IEnumerable<Reader> Readers { get; set; }
    }

    public class ListHasElements : ValidationAttribute
    {       
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            return ((List<int>) value).Any();
        }
    }
}