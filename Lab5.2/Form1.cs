using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giai_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            if (double.TryParse(Hesoa.Text, out a) &&
                double.TryParse(hesob.Text, out b) &&
                double.TryParse(hesoc.Text, out c))
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            textBox1.Text = "Phương trình vô số nghiệm";
                        else
                            textBox1.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        double x = -c / b;
                        textBox1.Text = "Phương trình bậc nhất x = " + x;
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;

                    if (delta < 0)
                    {
                        textBox1.Text = "Phương trình vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        textBox1.Text = "x = " + x;
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        textBox1.Text = "Phương trình có 2 nghiệm x1 = " + x1 + " x2 = " + 2;
                    }
                }
            }
            else
            {
                MessageBox.Show(" AHIHI BẠN NHẬP SAI RỒI -> Vui lòng nhập số");
            }
        }
    }
}


            
            
        
    


