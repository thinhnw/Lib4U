using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lib4U.Models
{
    public class Reservation
    {
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}