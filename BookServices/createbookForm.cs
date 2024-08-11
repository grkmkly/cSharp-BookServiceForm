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
    public partial class createbookForm : Form
    {
        public createbookForm()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = textBoxName.Text;
            b.Author = textBoxAuthor.Text;
            b.Pages = textBoxPages.Text;
            b.Topic = textBoxTopic.Text;
            httpClass httpClass = new httpClass();
            await httpClass.CreateBook(b);
        }
    }
}
