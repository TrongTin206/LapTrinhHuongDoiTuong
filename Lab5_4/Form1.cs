using System;
using System.Windows.Forms;

namespace Lab5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox2.TextAlign = HorizontalAlignment.Right;
        }

        private void TinhTien()
        {
            if (!double.TryParse(textBox1.Text, out double km) || km < 0)
            {
                textBox2.Text = "0";
                return;
            }

            double tien = 0;

            if (radioButton1.Checked) // Xe 7 chỗ
            {
                if (km <= 1)
                    tien = 17000;
                else if (km <= 5)
                    tien = 17000 + (km - 1) * 15000;
                else if (km <= 100)
                    tien = 17000 + 4 * 15000 + (km - 5) * 12000;
                else
                    tien = 17000 + 4 * 15000 + 95 * 12000 + (km - 100) * 11000;
            }
            else if (radioButton2.Checked) // Xe 4 chỗ
            {
                if (km <= 1)
                    tien = 15000;
                else if (km <= 5)
                    tien = 15000 + (km - 1) * 13500;
                else if (km <= 100)
                    tien = 15000 + 4 * 13500 + (km - 5) * 11000;
                else
                    tien = 15000 + 4 * 13500 + 95 * 11000 + (km - 100) * 10000;
            }

            if (checkBox1.Checked)
                tien *= 0.95;

            textBox2.Text = ((long)tien).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void buttom1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}