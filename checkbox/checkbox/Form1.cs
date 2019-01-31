using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Вашият избор е:\n ";
            if (checkBox1.Checked == true) s = s + checkBox1.Text + " \n";
            if (checkBox2.Checked == true) s = s + checkBox2.Text + " \n";
            if (checkBox3.Checked == true) s = s + checkBox3.Text + " \n";
            label2.Text = s;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
