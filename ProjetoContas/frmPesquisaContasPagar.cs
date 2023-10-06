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
    public partial class frmPesquisaContasPagar : Form
    {
        private int codigoContasPagar;
        public frmPesquisaContasPagar()
        {
            InitializeComponent();
        }

        private void tb_contaspagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaspagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCadastroDataSet);

        }

            private void frmPesquisaContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_contaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaspagarTableAdapter.Fill(this.bDCadastroDataSet.tb_contaspagar);

        }

        private void pesquisarTextBox_TextChanged(object sender, EventArgs e)
        {
            string nome = pesquisarTextBox.Text;
            if (nome == "")
            {
                this.tb_contaspagarTableAdapter.Fill(this.bDCadastroDataSet.tb_contaspagar);
            }
            else
            {
                this.tb_contaspagarTableAdapter.FillByNome(this.bDCadastroDataSet.tb_cliente, "%" + nome + "%");
            }
        }

        private void tb_contaspagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigoContasPagar = int.Parse(tb_contaspagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigoContasPagar = 0;
            Close();
        }
    }
}
