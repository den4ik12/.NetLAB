using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string str = "";
            decimal number = numericUpDown1.Value;
            for (int i = 1; i <= number; i++)
                str+=($" {i}");
            textBox1.Text = str; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p2_comboBox1.Items.Add(p2_textBox1.Text);
        }

        private void p2_button2_Click(object sender, EventArgs e)
        {
            p2_comboBox1.Items.Clear();
        }

        private void p2_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p2_textBox2.Text = p2_comboBox1.SelectedItem.ToString();
        }

        private void p3_button1_Click(object sender, EventArgs e)
        {
            p3_textBox3.Text = Convert.ToString(Convert.ToDouble(p3_textBox1.Text) + Convert.ToDouble(p3_textBox2.Text));
        }

        private void p3_button2_Click(object sender, EventArgs e)
        {
            p3_textBox3.Text = Convert.ToString(Convert.ToDouble(p3_textBox1.Text) - Convert.ToDouble(p3_textBox2.Text));
        }

        private void p3_button3_Click(object sender, EventArgs e)
        {
            p3_textBox3.Text = Convert.ToString(Convert.ToDouble(p3_textBox1.Text) * Convert.ToDouble(p3_textBox2.Text));
        }

        private void p3_button4_Click(object sender, EventArgs e)
        {
            p3_textBox3.Text = Convert.ToString(Convert.ToDouble(p3_textBox1.Text) / Convert.ToDouble(p3_textBox2.Text));
        }

        private void p4_button1_Click(object sender, EventArgs e)
        {
            p4_comboBox1.Items.Clear();
            string[] array_value = p4_textBox2.Lines;
            int m;
            double d;
            foreach (string value in array_value)
            {
                if (double.TryParse(value, out d)){
                    p4_comboBox1.Items.Add(d);
                }
            }
        }

        private void p5_button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double mark = Convert.ToDouble(p5_numericUpDown1.Value);
            double current = 1;
            for (int i = 2; current>mark; i++) 
            {
                current = 1.0 / i;
                sum += current;
                p5_textBox1.Text += $"{sum}\r\n";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int m;
            double d;
            string[] array_value = p6_textBox1.Lines;
            for (int i = array_value.Length-1; i >= 0; i--)
            {
                if (double.TryParse(array_value[i], out d))
                {
                    p6_textBox2.Text += $"{array_value[i]}\r\n";
                }
            }
        }

        private void p7_button1_Click(object sender, EventArgs e)
        {
            double start = Convert.ToDouble(p7_textBox1.Text);
            double end = Convert.ToDouble(p7_textBox2.Text);
            double h = Convert.ToDouble(p7_textBox3.Text);
            for (double x = start; x <= end; x += h)
                p7_textBox4.Text += $"x={x};  f(x)={Math.Sin(x)*180/Math.PI/(Math.Abs(x)+1)}\r\n";
        }

        private void p4_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void p6_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
