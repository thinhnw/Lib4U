using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lib4U.Models
{
    public class BookAndMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Total_pages { get; set; }
        public decimal Rating { get; set; }
        public string PublisherName { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
    }
}