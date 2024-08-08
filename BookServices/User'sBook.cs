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
    public partial class User_sBook : Form
    {
        public string objectID;
        public User_sBook()
        {
            InitializeComponent();
        }
        public User_sBook(string objectID)
        {
            this.objectID = objectID;
            InitializeComponent();
        }

        async private void User_sBook_Load(object sender, EventArgs e)
        {
            httpClass httpClass = new httpClass();
            User response = await httpClass.getUserbyId(this.objectID);
            if (response.Books == null)
            {
                listBox1.Items.Add("Kitap bulunamadı..");
                return;
            }
            for (int i = 0; i < response.Books.Count; i++)
            {
                string result = string.Format("Book Name : {0} Book Author : {1} Book Pages : {2}", response.Books[i].Name, response.Books[i].Author, response.Books[i].Pages);
                listBox1.Items.Add(result);
            }
        }
    }
}
