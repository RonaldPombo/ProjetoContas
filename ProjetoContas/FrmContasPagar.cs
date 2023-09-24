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
    public partial class FrmContasPagar : Form
    {
        public FrmContasPagar()
        {
            InitializeComponent();
        }

        private void Tb_contaspagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaspagarBindingSource.EndEdit();
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDCadastroDataSet.tb_contaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaspagarTableAdapter.Fill(this.bDCadastroDataSet.tb_contaspagar);
            Desabilita();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_contaspagarBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_contaspagarBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            tb_contaspagarBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cd_contasPagarTextBox.Text))
            {
                MessageBox.Show("ID invalido ou vazio");
            }
            else { Habilitar(); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                tb_contaspagarBindingSource.RemoveCurrent();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não tem nada para excluir");
            }
            finally
            {
                tb_contaspagarTableAdapter.Update(bDCadastroDataSet.tb_contaspagar);
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contaspagarBindingSource.EndEdit();
            tb_contaspagarTableAdapter.Update(bDCadastroDataSet.tb_contaspagar);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_contaspagarBindingSource.CancelEdit();
        }
        private void Habilitar()
        {
            cd_contasPagarTextBox.Enabled = false;
            ds_contaTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            cd_fornecedorTextBox.Enabled = true;

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
            cd_contasPagarTextBox.Enabled = false;
            ds_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;

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

        private void Vl_contaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Vl_pagoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
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
