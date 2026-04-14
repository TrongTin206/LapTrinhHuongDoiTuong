using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textnboxnhap.Text;
            double banKinh = 0;

            if (double.TryParse(input, out banKinh))
            {
                double kq = Math.PI * 2 * banKinh;
                textBox1.Text = "Chu vi hình tròn =" + kq;
            }
            else
            {
                MessageBox.Show("AHUHU BẠN SAI RỒI -> Vui lòng nhập số nhé");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textnboxnhap.Text;
            double banKinh = 0;

            if (double.TryParse(input, out banKinh))
            {
                double kq = Math.PI * banKinh * banKinh;
                textBox1.Text = "Diện tích hình tròn =" + kq;
            }
            else
            {
                MessageBox.Show("AHUHU BẠN SAI RỒI -> Vui lòng nhập số nhé");
            }
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textnboxnhap_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
