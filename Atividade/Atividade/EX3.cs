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

            if (a == b && a == c && b == c) {
                lblResult.Text = "Triangulo Equilátero – possui os três lados com medidas iguais";
            }
            else if (a == b && a == c && c != a || a != b && b == c && c == a || b != c && a == b && a == c)
            {
                lblResult.Text = "Triangulo Isósceles – possui dois lados com medidas iguais";

            }
            else if ( a != b && b!= c &&  a != c) {
                lblResult.Text = "Triangulo Escaleno – possui os três lados com medidas diferentes.";
            }
            else {
                lblResult.Text = "Não forma um triângulo.";
            }
        }
    }
}
