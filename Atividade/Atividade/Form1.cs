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
    public partial class fmJanela : Form
    {
        public fmJanela()
        {
            InitializeComponent();
        }

        private void eX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX1 windowEX1 = new EX1();
            windowEX1.MdiParent = this;
            windowEX1.Show();
        }

        private void eX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX2 windowEX2 = new EX2();
            windowEX2.MdiParent = this;
            windowEX2.Show();
        }

        private void eX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX3 windowEX3 = new EX3();
            windowEX3.MdiParent = this;
            windowEX3.Show();
        }

        private void eX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX4 windowEX4 = new EX4();
            windowEX4.MdiParent = this;
            windowEX4.Show();
        }

        private void eX5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX5 windowEX5 = new EX5();
            windowEX5.MdiParent = this;
            windowEX5.Show();
        }

        private void eX6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX6 windowEX6 = new EX6();
            windowEX6.MdiParent = this;
            windowEX6.Show();
        }

        private void eX7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX7 windowEX7 = new EX7();
            windowEX7.MdiParent = this;
            windowEX7.Show();
        }

        private void fmJanela_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }
    }
}
