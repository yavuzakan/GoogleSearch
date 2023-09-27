using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Icon = new Icon("yca.ico");
        }
        public void ara()
        {
            string q = "";
            string text = textBox1.Text;

            text = text.Replace(' ','+');

            try
            {
                
                String komut = "google.com/search?q=" + text + " ";




                System.Diagnostics.Process.Start("chrome.exe",komut);


              





            }
            catch (Exception ex)
            {



            }

            textBox1.Text = "";


        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ara();
               
            }
                
        }
    }
}
