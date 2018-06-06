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
            else if (num == 3) {
            
            }
            else if (num == 4)
            {

            }
            else if (num == 5)
            {

            }
            else if (num == 6)
            {

            }
            else if (num == 7) {
            
            }
        }
    }
}
