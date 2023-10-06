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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigoFornecedor;
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCadastroDataSet);

        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bDCadastroDataSet.tb_fornecedor);

        }

        public int GetCodigo()
        {
            return codigoFornecedor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigoFornecedor = 0;
            Close();
        }

        private void pesquisarTextBox_TextChanged(object sender, EventArgs e)
        {
            string nome = pesquisarTextBox.Text;
            if (nome == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.bDCadastroDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.bDCadastroDataSet.tb_fornecedor, "%" + nome + "%");
            }
        }

        private void tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigoFornecedor = int.Parse(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
