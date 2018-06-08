using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.name== textBox_userName.Text && login.password == textBox_password.Text)
            {
                this.Hide();
                Form1 form1 = new Form1(this);
                form1.Show();
            }
            else{
                MessageBox.Show("Incorret Information");
            }
        }
    }
}
