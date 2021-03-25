using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                MessageBox.Show("Hi "+textBox1.Text);
                label1.Hide();
                textBox1.Hide();
                this.timer1.Start();
                label2.Hide();
                button1.Hide();
                button2.Hide();
            }
            else
            {
                MessageBox.Show("Enter a name");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            label1.Show();

            if (progressBar1.Value == 100)
            {
                Form Standardselect = new Standardselect();
                Standardselect.Show();
                this.Hide();
                timer1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
