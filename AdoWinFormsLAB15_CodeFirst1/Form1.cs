using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AdoWinFormsLAB15_CodeFirst1.dbModel;
using AdoWinFormsLAB15_CodeFirst1.dbContext;
namespace AdoWinFormsLAB15_CodeFirst1
{
    public partial class Form1 : Form
    {
        LibraryContext db = new LibraryContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Authors.Load();
            listBox1.DataSource = db.Authors.ToList();
            listBox1.DisplayMember = "Info";
            listBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = true;
            listBox1.DataSource = db.Users.Where(u => u.IsDebtor == true).ToList();
            listBox1.DisplayMember = "Info";
            listBox1.ValueMember = "Id";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Book book = await db.Books.FirstOrDefaultAsync(b => b.Title == "Book3");
            await db.Entry(book).Collection(a => a.Authors).LoadAsync();
            listBox1.DataSource = book.Authors.ToList();
            listBox1.DisplayMember = "Info";
            listBox1.ValueMember = "Id";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            db.Configuration.LazyLoadingEnabled = false;
            await db.Books.LoadAsync();
            foreach (Book book in db.Books)
            {
                if (book.UserId == null) 
                {
                    listBox1.Items.Add(book.Info);
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false;
            User user = await db.Users.FirstOrDefaultAsync(u => u.UserName == "User1");
            await db.Entry(user).Collection(u => u.Books).LoadAsync();
            listBox1.DataSource = user.Books.ToList();
            listBox1.DisplayMember = "Info";
            listBox1.ValueMember = "Id";
        }
    }
}
