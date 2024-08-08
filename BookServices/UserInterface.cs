using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookServices
{
    public partial class UserInterface : Form
    {
        private string objectID;
        private string username;
        public UserInterface(string objectId,string username)
        {
            this.objectID = objectId;
            this.username = username;
            InitializeComponent();
        }
        public UserInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_sBook user_SBook = new User_sBook(this.objectID);
            user_SBook.Show();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            label2.Text = this.username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this.objectID);
            addBook.Show();
        }
    }
}
