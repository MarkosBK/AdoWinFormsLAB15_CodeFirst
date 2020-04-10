using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWinFormsLAB15_CodeFirst1.dbModel
{
    public class Author
    {
        public int Id { get; set; }
        [Column(name: "AuthorName")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Необходимо ввести название имя автора")]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
        public Author()
        {
            Books = new HashSet<Book>();
        }
        [NotMapped]
        public string Info
        {
            get
            {
                return $"ID: {Id,-10} AuthorName: {Name,-20}";
            }
        }
    }
}
