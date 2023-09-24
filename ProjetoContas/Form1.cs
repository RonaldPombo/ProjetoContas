using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario fu = new FrmUsuario();
            fu.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente fu = new FrmCliente();
            fu.ShowDialog();
        }

        private void ConsumidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsumidores fu = new FrmConsumidores();
            fu.ShowDialog();
        }

        private void ContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasPagar fu = new FrmContasPagar();
            fu.ShowDialog();
        }

        private void ContasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasReceber fu = new FrmContasReceber();
            fu.ShowDialog();
        }
    }
}
