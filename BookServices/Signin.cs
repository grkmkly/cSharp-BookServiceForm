﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using httpServices;

namespace BookServices
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            httpClass httpClass = new httpClass();
            httpServices.User user = new httpServices.User();
            user.Username = usernameBox.Text;
            user.Password = passwordBox.Text;
            Respon resultS = await httpClass.PostSignin(user);
            if (resultS.isActive)
            {
                UserInterface userInterface = new UserInterface(resultS.ID,resultS.username);
                this.Close();
                userInterface.Show();
                return;
            }
            label3.Text = "Username or password false";
            return;
            
        }

    }
}
