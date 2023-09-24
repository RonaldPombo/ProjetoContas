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
    public partial class frmPesquisaCliente : Form
    {
        private int codigoCliente;

        public int GetCodigo()
        {
            return codigoCliente;
        }

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void Tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();

        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bDCadastroDataSet.tb_cliente);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = pesquisarTextBox.Text;
            if (nome == "")
            {
                this.tb_clienteTableAdapter.Fill(this.bDCadastroDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByNome(this.bDCadastroDataSet.tb_cliente, "%" + nome + "%");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigoCliente = 0;
            Close();
        }

        private void Tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = int.Parse(tb_clienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
