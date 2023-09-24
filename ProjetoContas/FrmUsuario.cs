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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bDCadastroDataSet.tb_usuario);
            Desabilita();
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Habilitar()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_loginTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            Button10.Enabled = false;
        }
        private void Desabilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            Button10.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(bDCadastroDataSet.tb_usuario);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_usuarioBindingSource.CancelEdit();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            tb_usuarioBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cd_usuarioTextBox.Text))
            {
                MessageBox.Show("ID invalido ou vazio");
            }
            else { Habilitar(); }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                tb_usuarioBindingSource.RemoveCurrent();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não tem nada para excluir");
            }
            finally
            {
                tb_usuarioTableAdapter.Update(bDCadastroDataSet.tb_usuario);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {   
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            int codigoUsuario = fpu.GetCodigo();
            if (codigoUsuario > 0)
            {
                int reg = tb_usuarioBindingSource.Find("cd_usuario", codigoUsuario);
                tb_usuarioBindingSource.Position = reg;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataEnter_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.White;
                ((TextBox)sender).BackColor = Color.LightBlue;
            }
            else if (sender is ComboBox)
            {
                ((ComboBox)sender).ForeColor = Color.White;
                ((ComboBox)sender).BackColor = Color.LightBlue;
            }
        }

        private void DataEnter_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).BackColor = Color.White;
            }
            else if (sender is ComboBox)
            {
                ((ComboBox)sender).ForeColor = Color.Black;
                ((ComboBox)sender).BackColor = Color.White;
            }
        }
    }
}
