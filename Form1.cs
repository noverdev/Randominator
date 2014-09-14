using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randominator
{
    public partial class Randominator : Form
    {
        public Randominator()
        {
            InitializeComponent();
        }
        private Color color;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Від :";
            label2.Text = "До :";
            label3.Text = "Результат :";
            label4.Text = "Тема :";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = 0;
            for (int i = 0; i <= b; i++)
            {
                Random RandomNumber1 = new Random();
                 c = RandomNumber1.Next(a, b);
            }
            textBox3.Text = c.ToString();
        }
        private void click_Color(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
            panel2.BackColor = color;
            panel3.BackColor = color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear(); 
        }
        private void press_Key(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        

       
    }
}
