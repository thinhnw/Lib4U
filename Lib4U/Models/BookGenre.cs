using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lib4U.Models
{
    public class BookGenre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int GenreId { get; set; }
        public virtual Book Books { get; set; }
        public virtual Genre Genres { get; set; }
    }
}