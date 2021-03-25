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
namespace Read_and_Write_Text_From__.txt__files
{
    public partial class My_Form : Form
    {
        public My_Form()
        {
            InitializeComponent();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Employees\\" + FirstNameTB.Text + " " + LastNameTB.Text + ".txt");
            //Path of .txt file  
            // separate files for separate employees

            sw.WriteLine(label1.Text + "" + FirstNameTB.Text);
            sw.WriteLine(label2.Text + "" + LastNameTB.Text);
            sw.WriteLine(label4.Text + "" + GenderCB.Text);
            sw.WriteLine(label3.Text + "" + AddressTB.Text);
            sw.Close();





            StreamReader sr = new StreamReader(Application.StartupPath + "\\Employees\\" + FirstNameTB.Text + " " + LastNameTB.Text + ".txt");

            ReadFilesRTD.Text = sr.ReadToEnd();

            sr.Close();
        }
    }
}
