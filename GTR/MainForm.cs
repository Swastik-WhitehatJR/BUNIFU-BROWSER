using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_s_Report_App
{
    public partial class MainForm : Form
    {
        public MainForm(string Str_Value)
        {
            InitializeComponent();
            label3.Text = Str_Value;
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            pnlNav.Hide();
            pictureBox1.Show();
            panel1.Hide();
        }


        private void Dashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            pictureBox1.Show();
            panel1.Hide();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            panel10.Show();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            pnlNav.Hide();
            panel1.Show();
            pictureBox1.Hide();
        }

        private void btnAddDiagonasis_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            pnlNav.Hide();
            panel10.Hide();
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            pnlNav.Hide();
            panel10.Hide();
            panel11.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            panel13.Show();
            panel10.Hide();
            panel11.Hide();
            panel14.Hide();
            panel15.Hide();
            pnlNav.Hide();
            panel12.Hide();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            panel14.Show();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            pnlNav.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            panel15.Show();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            pnlNav.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
