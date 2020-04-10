using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdoWinFormsLAB15_CodeFirst1.dbModel
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<Author> Authors { get; set; }
        public Book()
        {
            Authors = new HashSet<Author>();
        }
        [NotMapped]
        public string Info
        {
            get
            {
                return $"ID: {Id,-10} Title: {Title,-20} Price: {Price,-10} Pages:{Pages,-10} UserId: {UserId}";
            }
        }
    }
}
