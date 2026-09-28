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

namespace pdpdpd
{
    public partial class Form1 : Form
    {

        private int A;
        private int B = 0;

        public Form1()
        {
            InitializeComponent();
            button2.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A++;
            button3.Text = A.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            A--;
            button3.Text = A.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Text = B.ToString();
            A = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text file|*.txt";
            saveFileDialog1.FileName = "Record 1";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName,button3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
