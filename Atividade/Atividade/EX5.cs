﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class EX5 : Form
    {
        public EX5()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(txbNum.Text);
            double i = 0;

            while (i < num)
            {
                i++; 

                if (i <= num)
                {
                    MessageBox.Show(i.ToString());

                    if (num > 50)
                    {
                        MessageBox.Show("Número maior que 50.");
                        break;
                    }
                }

            }

        }
    }
}
