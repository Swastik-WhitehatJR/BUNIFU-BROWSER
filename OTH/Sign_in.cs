using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Doctors_s_Report_App
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FirstName.Text != "" || LastName.Text != "" || Gender.Text != "" || Phone.Text != "" || UserName.Text != "" || Email.Text != "" || Password.Text != "" || UserName.Text != "UserName" || Email.Text != "Email" || Password.Text != "Password")
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Profiles\\" + /*FirstName.Text + " " + LastName.Text*/ UserName.Text + " " + Password.Text + ".txt");


                sw.WriteLine(label1.Text + "" + FirstName.Text);
                sw.WriteLine(label4.Text + "" + LastName.Text);
                sw.WriteLine(label5.Text + "" + Gender.Text);
                sw.WriteLine(label6.Text + "" + Phone.Text);
                sw.WriteLine("Username:" + "" + UserName.Text);
                sw.WriteLine("Email:" + "" + Email.Text);
                sw.WriteLine("Password:" + "" + Password.Text);
                sw.Close();

                Form Log_in = new LOGIN();
                Log_in.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill all the details!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
    }
}
