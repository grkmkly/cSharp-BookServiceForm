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
                string format = string.Format("Object ID :{0}: Name :{1}: Author :{2}: Pages :{3}:",books[i].ObjectID, books[i].Name, books[i].Author, books[i].Pages);
                listBox1.Items.Add(format);
            }
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            string bookString = listBox1.SelectedItem.ToString();
            string bookObjectID = bookString.Split(':')[1];

            Book book = new Book();
            book.ObjectID = bookObjectID;
            User user = new User();
            user.ObjectId = this.objectId;
            httpClass httpclass = new httpClass();
            Respon resp = await httpclass.addbookUser(user, book);
            if (resp.isActive)
            {
                MessageBox.Show("Added");
            }

        }
    }
}
