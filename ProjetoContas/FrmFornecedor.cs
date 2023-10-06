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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void Tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
        }

        private void FrmConsumidores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bDCadastroDataSet.tb_fornecedor);
            Desabilita();

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            tb_fornecedorBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cd_consumidoresTextBox.Text))
            {
                MessageBox.Show("ID invalido ou vazio");
            }
            else { Habilitar(); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                tb_fornecedorBindingSource.RemoveCurrent();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não tem nada para excluir");
            }
            finally
            {
                tb_fornecedorTableAdapter.Update(bDCadastroDataSet.tb_fornecedor);
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Verificar() == true)
            {
                Desabilita();
                Validate();
                tb_fornecedorBindingSource.EndEdit();
                tb_fornecedorTableAdapter.Update(bDCadastroDataSet.tb_fornecedor);
            }
            else
            {
                MessageBox.Show("Dados Invalidos");
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_fornecedorBindingSource.CancelEdit();
        }
        private void Habilitar()
        {
            cd_consumidoresTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
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
            cd_consumidoresTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
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
        private bool Verificar()
        {
            if (VerificarCNPJ() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public bool VerificarCNPJ()
        {
            double digito1 = 0, digito2 = 0;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
            digito1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;

            digito1 = digito1 % 11;

            if (digito1 < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - digito1;
            }

            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            digito2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;

            digito2 = digito2 % 11;

            if (digito2 < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - digito2;
            }

            bool cnpj;
            if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) != digito1.ToString() ||
                cd_cnpjMaskedTextBox.Text.Substring(17, 1) != digito2.ToString())
            {
                cnpj = false;
            }
            else
            {
                cnpj = true;
            }
            return cnpj;
        }
    }
}
