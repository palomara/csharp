using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class EX3 : Form
    {
        public EX3()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            double a = System.Convert.ToDouble(txbA.Text);
            double b = System.Convert.ToDouble(txbB.Text);
            double c = System.Convert.ToDouble(txbC.Text);

            if ((b - c) < a && a < (b + c))
            {
                if ((a - c) < b && b < (a + c))
                {
                    if ((a - b) < c && c < (a + b))
                    {
                        if (a == b && b == c)
                        {
                            lblResult.Text = "Triângulo Equilátero";
                        }

                        else if (a == b || b == c || c == a)
                        {
                             lblResult.Text = "Triângulo Isósceles" ;
                        }

                        else
                        {
                            lblResult.Text = "Triângulo Escaleno";
                        }
                    }
                }
            }

            else
            {
                lblResult.Text = "Não forma um triângulo!";
            }
        }
    }
}
