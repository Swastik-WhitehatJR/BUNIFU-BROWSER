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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form Sign_in = new Sign_in();
            Sign_in.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Profiles\\" +  UserName.Text + " " + Password.Text + ".txt"))
            {
                Form MainForm = new MainForm(UserName.Text);
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Profile doesn't exists!" + " Please Sign in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
