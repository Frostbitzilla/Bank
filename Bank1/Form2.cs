using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank1
{
    public partial class Form2 : Form

    {
        
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button_Createyouraccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You already create your account ");
            string l1 = textBox_realname.Text;
            string l2 = textBox_createuser.Text;
            string l3 = textBox_DD.Text;
            string l4 = textBox_MM.Text;
            string l5 = textBox_YYYY.Text;
            string l6 = textBox_createpassword.Text;
            


            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
