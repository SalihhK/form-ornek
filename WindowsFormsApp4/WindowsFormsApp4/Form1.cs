using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısa=Convert.ToInt32(textBox1.Text);//kısa değerini 1.kutucuğa aktardık
            int uzun=Convert.ToInt32(textBox2.Text);// uzun değerini 2.kutucuğa aktardık
            int cevre=2*(kısa+uzun);//çevreyi tanımladık 
            int alan = kısa * uzun;//alanı tanımladık
            label3.Text = "Çevre:" + cevre;//çevre değerini 3.kutucuğa aktardık
            label4.Text="Alan:"+ alan;//alan değerini 4.kutucuğa aktardık
            
        }
    }
}
