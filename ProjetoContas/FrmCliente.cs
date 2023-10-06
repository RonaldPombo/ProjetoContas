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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bDCadastroDataSet.tb_cliente);
            Desabilita();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            tb_clienteBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cd_clienteTextBox.Text))
            {
                MessageBox.Show("ID invalido ou vazio");
            }
            else { Habilitar(); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try {
                tb_clienteBindingSource.RemoveCurrent();
            }
            catch(InvalidOperationException) {
                MessageBox.Show("Não tem nada para excluir");
            }
            finally
            {
                tb_clienteTableAdapter.Update(bDCadastroDataSet.tb_cliente);
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter.Update(bDCadastroDataSet.tb_cliente);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_clienteBindingSource.CancelEdit();
        }
        private void Habilitar()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            button10.Enabled = false;
        }
        private void Desabilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            button10.Enabled = true;
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

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            int codigoCliente = fpc.GetCodigo();
            if (codigoCliente > 0)
            {
                int reg = tb_clienteBindingSource.Find("cd_cliente", codigoCliente);
                tb_clienteBindingSource.Position = reg;
            }
        }

        private bool Verificar()
        {
            if (VerificarCPF() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarCPF()
        {
            double digito1 = 0, digito2 = 0;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
            digito1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;

            digito1 = digito1 % 11;

            if (digito1 < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - digito1;
            }

            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
            digito2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;

            digito2 = digito2 % 11;

            if (digito2 < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - digito2;
            }

            bool cpf;
            if (cd_cpfMaskedTextBox.Text.Substring(13, 1) != digito1.ToString() ||
                cd_cpfMaskedTextBox.Text.Substring(12, 1) != digito2.ToString())
            {
                cpf = false;
            }
            else
            {
                cpf = true;
            }
            return cpf;
        }
    }
}
