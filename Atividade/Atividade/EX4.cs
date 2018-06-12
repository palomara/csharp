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
    public partial class EX4 : Form
    {
        public EX4()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {   
            double num = System.Convert.ToDouble(txbNum.Text);

            if (num == 1) {
                lblMes.Text = "Janeiro!";
            }
            else if (num == 2)
            {
                lblMes.Text = "Fevereiro!";
            }
            else if (num == 3) {
                lblMes.Text = "Março!";
            }
            else if (num == 4)
            {
                lblMes.Text = "Abril!";
            }
            else if (num == 5)
            {
                lblMes.Text = "Maio!";
            }
            else if (num == 6)
            {
                lblMes.Text = "Junho!";

            }
            else if (num == 7) {
                lblMes.Text = "Julho!";
            }
            else if (num == 8)
            {
                lblMes.Text = "Agosto!";
            }
            else if (num == 9)
            {
                lblMes.Text = "Setembro!";
            }
            else if (num == 10)
            {
                lblMes.Text = "Outubro!";
            }
            else if (num == 11)
            {
                lblMes.Text = "Novembro!";
            }
            else if (num == 12)
            {
                lblMes.Text = "Dezembro!";
            }
            else
            {
                lblMes.Text = "Mês não existe.";
            }
        }

    

    }
}
