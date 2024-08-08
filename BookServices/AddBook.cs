using httpServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookServices
{
    public partial class AddBook : Form
    {
        public string objectId;
        public AddBook(string objectId)
        {
            this.objectId = objectId;
            InitializeComponent();
        }
        public AddBook()
        {
            InitializeComponent();
        }

        async private void AddBook_Load_1(object sender, EventArgs e)
        {
            httpClass httpClass = new httpClass();
            List<Book> books = await httpClass.getBooks<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                string format = string.Format("Name : {0} Author : {1} Pages : {2}", books[i].Name, books[i].Author, books[i].Pages);
                listBox1.Items.Add(format);
            }
        }
    }
}
