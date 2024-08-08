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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            httpClass httpClass = new httpClass();
            httpServices.User user = new httpServices.User(Rusername.Text, Rpassword.Text);
            Respon resultR = await httpClass.PostRegister(user);
            if (resultR.isActive)
            {
                RegisterLabel.Text = "Selamlar Naber?";
                return;
            }
            RegisterLabel.Text = "Username is not available";
        }
    }
}
