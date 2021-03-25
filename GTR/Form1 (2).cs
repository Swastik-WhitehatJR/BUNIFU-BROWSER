using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEB_BROWSSER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser5.Navigate("https://www.google.com/search?client=firefox-b-d&q="+textBox1.Text);
            webBrowser1.Navigate("https://www.youtube.com/results?search_query=" + textBox1.Text);
            webBrowser4.Navigate("https://www.bing.com/search?q=" + textBox1.Text); 
            webBrowser3.Navigate("https://in.search.yahoo.com/search;_ylt=" + textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser5.Refresh();
           // webBrowser1.Refresh();
           // webBrowser4.Refresh();
           // webBrowser3.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser5.GoForward();
           // webBrowser1.GoForward();
           // webBrowser4.GoForward();
           // webBrowser3.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser5.GoBack();
        }
    }
}
