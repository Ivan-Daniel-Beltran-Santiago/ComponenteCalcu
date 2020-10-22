using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreríaPractica;

namespace ComponenteCalculadora
{
    public partial class UserControl1 : UserControl
    {
        double num1, num2, op;

        public UserControl1()
        {
            InitializeComponent();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "7";
        }
        private void btn8_Click_1(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "8";
        }
        private void btn9_Click_1(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "9";
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "4";
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "6";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "3";
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            op = 1;
            num1 = double.Parse(tbxDisplay.Text);
            tbxDisplay.Clear();
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            op = 2;
            num1 = double.Parse(tbxDisplay.Text);
            tbxDisplay.Clear();
        }
        private void btnMulti_Click_1(object sender, EventArgs e)
        {
            op = 3;
            num1 = double.Parse(tbxDisplay.Text);
            tbxDisplay.Clear();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            op = 4;
            num1 = double.Parse(tbxDisplay.Text);
            tbxDisplay.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxDisplay.Text.Length <= 1)
            {
                tbxDisplay.Text = tbxDisplay.Text + "";
            }
            else
            {
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxDisplay.Clear();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(tbxDisplay.Text);

            Opera ciones = new Opera(num1, num2);

            switch (op)
            {
                case 1:
                    ciones.Suma();
                    tbxDisplay.Text = Convert.ToString(ciones.R);
                    break;
                case 2:
                    ciones.Resta();
                    tbxDisplay.Text = Convert.ToString(ciones.R);
                    break;
                case 3:
                    ciones.Multi();
                    tbxDisplay.Text = Convert.ToString(ciones.R);
                    break;
                case 4:
                    ciones.Divide();
                    if (num2 == 0)
                    {
                        tbxDisplay.Text = "Syntax ERROR";
                    }
                    else
                    {
                        tbxDisplay.Text = Convert.ToString(ciones.R);
                    }
                    break;
            }
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbxDisplay.Text.Contains("."))
            {
                if (tbxDisplay.Text.Length < 1)
                {
                    tbxDisplay.Text = tbxDisplay.Text + "0.";
                }
                else
                {
                    tbxDisplay.Text = tbxDisplay.Text + ".";
                }
            }
        }
    }
}
