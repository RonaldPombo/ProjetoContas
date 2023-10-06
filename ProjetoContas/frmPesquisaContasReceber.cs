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
    public partial class frmPesquisaContasReceber : Form
    {
        private int codigoContasReceber;
        public frmPesquisaContasReceber()
        {
            InitializeComponent();
        }

        private void tb_contasreceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contasreceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCadastroDataSet);

        }

        private void frmPesquisaContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_contasreceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasreceberTableAdapter.Fill(this.bDCadastroDataSet.tb_contasreceber);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigoContasReceber = 0;
            Close();
        }

        private void pesquisarTextBox_TextChanged(object sender, EventArgs e)
        {
            string nome = pesquisarTextBox.Text;
            if (nome == "")
            {
                this.tb_contasreceberTableAdapter.Fill(this.bDCadastroDataSet.tb_contasreceber);
            }
            else
            {
                this.tb_contasreceberTableAdapter.FillByNome(this.bDCadastroDataSet.tb_cliente, "%" + nome + "%");
            }
        }

        private void tb_contasreceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigoContasReceber = int.Parse(tb_contasreceberDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
