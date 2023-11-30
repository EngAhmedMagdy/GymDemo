using GymDemo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = username_input.Text;
            string passward = passward_input.Text;
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(passward))
            {
                if(UserData.userlist.Any(x=>x.Username == name && x.Password == passward))
                {
                    //welcome
                    MessageBox.Show("welcome");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong data");
                }
            }
            else
            {
                MessageBox.Show("enter pass & username");
            }
        }
    }
}
