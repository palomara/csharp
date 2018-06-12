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
    public partial class EX7 : Form
    {
        public EX7()
        {
            InitializeComponent();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            double a = 1.50, m = 1.10;
            int i = 0;
            while (m < a)
            {
                i++;

                a = a + 0.2;
                m = m + 0.3;
            }

            lblResposta.Text = "Em " + System.Convert.ToString(i) + " anos, Manoel será maior, alcançando " + m + " metros de altura.\nArlindo estará com " + a + " metros.";
        }

    }
}
