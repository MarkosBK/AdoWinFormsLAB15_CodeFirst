using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWinFormsLAB15_CodeFirst1.dbModel
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool IsDebtor { get; set; }
        public ICollection<Book> Books { get; set; }
        public User()
        {
            Books = new HashSet<Book>();
        }
        [NotMapped]
        public string Info
        {
            get
            {
                return $"ID: {Id,-10} UserName: {UserName,-20} IsDebtor: {IsDebtor}";
            }
        }
    }
}
