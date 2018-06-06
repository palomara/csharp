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
    public partial class EX1 : Form
    {
        public EX1()
        {
            InitializeComponent();
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);

            double R = ValorA + ValorB;
            double RMaior;
            double RMenor;

            if (R > 20)
            {
                RMaior = R + 8;
                lblRSoma.Text = RMaior.ToString();
            }
            else
            {
                RMenor = R - 5;
                lblRSoma.Text = RMenor.ToString();
            }

        }

       

        
    }
}