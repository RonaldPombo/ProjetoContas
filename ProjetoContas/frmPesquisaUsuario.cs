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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigoUsuario;

        public int GetCodigo()
        {
            return codigoUsuario;
        } 

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void Tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();

        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bDCadastroDataSet.tb_usuario);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigoUsuario = 0;
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = pesquisarTextBox.Text;
            if(nome == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.bDCadastroDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.bDCadastroDataSet.tb_usuario, "%"+nome+"%");
            }
        }

        private void Tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigoUsuario = int.Parse(tb_usuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
