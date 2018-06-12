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
    public partial class EX6 : Form
    {
        public EX6()
        {
            InitializeComponent();
        }

        private void btnQtd_Click(object sender, EventArgs e)
        {
            double qtd = System.Convert.ToDouble(TxbQtd.Text);
            lblResult.Text = "";

            for (int i = 1; i <= qtd; i++)
            {
                if (lblResult.Text == "")
                {
                    lblResult.Text = "Brasil" + "\n";
                }
                else
                {
                    lblResult.Text = lblResult.Text + "Brasil" + "\n";
                }

            }


        }

    }
}
