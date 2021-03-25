using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Independent_Web_Browser
{
    public partial class UBrowse : Form
    {
        public UBrowse()
        {
            InitializeComponent();
            panel2.Hide();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            webBrowsermain.GoForward();
        }

        private void next_Click(object sender, EventArgs e)
        {
            webBrowsermain.GoBack();
        }

        private void go_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.bing.com/search?q=" + textBox1.Text);
            // webBrowser5.Navigate("https://www.google.com/search?client=firefox-b-d&q=" + textBox1.Text);
            //  webBrowser1.Navigate("https://www.youtube.com/results?search_query=" + textBox1.Text);
            // webBrowsermain.Navigate("https://in.search.yahoo.com/search;_ylt=" + textBox1.Text);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowsermain.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.bing.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.yahoo.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.gmail.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.youtube.com");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowsermain.Navigate("https://www.amazon.com");
        }

        private void more_Click(object sender, EventArgs e)
        {
            Form DottedButton = new DottedButton();
            DottedButton.Show();
            this.Hide();
        }
    }

}
