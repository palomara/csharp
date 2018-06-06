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
    public partial class EX2 : Form
    {
        public EX2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(txbNum.Text);


            if (num % 10 == 0)
            {

                lblDivR.Text = "O núméro é divisível por 10.";

                if (num % 5 == 0)
                {
                    lblDivR.Text = "O número é divisível por 10 e 5.";
                }
                    if (num % 2 == 0)
                    {

                        lblDivR.Text = "O número é divisível por 10, 5 e 2.";
                    }
                
            }
                else if (num % 5 == 0)
                {
                    lblDivR.Text = "O número é divisível por 5.";

                    if (num % 2 == 0)
                    {
                        lblDivR.Text = "O número é divisível por 5 e 2.";
                    }
                }
                else if (num % 2 == 0)
                {
                    lblDivR.Text = "O número é divisível por 2.";
                }
                else
                {
                    lblDivR.Text = "Não é divisível por 10, 5 ou 2.";
                }
                
            }




        }

    }

