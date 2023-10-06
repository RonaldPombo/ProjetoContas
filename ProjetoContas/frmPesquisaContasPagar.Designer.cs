
namespace ProjetoContas
{
    partial class frmPesquisaContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.pesquisarTextBox = new System.Windows.Forms.TextBox();
            this.bDCadastroDataSet = new ProjetoContas.BDCadastroDataSet();
            this.tb_contaspagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contaspagarTableAdapter = new ProjetoContas.BDCadastroDataSetTableAdapters.tb_contaspagarTableAdapter();
            this.tableAdapterManager = new ProjetoContas.BDCadastroDataSetTableAdapters.TableAdapterManager();
            this.tb_contaspagarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaspagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaspagarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(366, 383);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeLabel.Location = new System.Drawing.Point(23, 41);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(80, 20);
            this.nomeLabel.TabIndex = 13;
            this.nomeLabel.Text = "Descrição";
            // 
            // pesquisarTextBox
            // 
            this.pesquisarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pesquisarTextBox.Location = new System.Drawing.Point(109, 38);
            this.pesquisarTextBox.Name = "pesquisarTextBox";
            this.pesquisarTextBox.Size = new System.Drawing.Size(669, 26);
            this.pesquisarTextBox.TabIndex = 12;
            this.pesquisarTextBox.TextChanged += new System.EventHandler(this.pesquisarTextBox_TextChanged);
            // 
            // bDCadastroDataSet
            // 
            this.bDCadastroDataSet.DataSetName = "BDCadastroDataSet";
            this.bDCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contaspagarBindingSource
            // 
            this.tb_contaspagarBindingSource.DataMember = "tb_contaspagar";
            this.tb_contaspagarBindingSource.DataSource = this.bDCadastroDataSet;
            // 
            // tb_contaspagarTableAdapter
            // 
            this.tb_contaspagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contaspagarTableAdapter = this.tb_contaspagarTableAdapter;
            this.tableAdapterManager.tb_contasreceberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.BDCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_contaspagarDataGridView
            // 
            this.tb_contaspagarDataGridView.AllowUserToAddRows = false;
            this.tb_contaspagarDataGridView.AllowUserToDeleteRows = false;
            this.tb_contaspagarDataGridView.AutoGenerateColumns = false;
            this.tb_contaspagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_contaspagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_contaspagarDataGridView.DataSource = this.tb_contaspagarBindingSource;
            this.tb_contaspagarDataGridView.Location = new System.Drawing.Point(27, 88);
            this.tb_contaspagarDataGridView.Name = "tb_contaspagarDataGridView";
            this.tb_contaspagarDataGridView.Size = new System.Drawing.Size(751, 289);
            this.tb_contaspagarDataGridView.TabIndex = 15;
            this.tb_contaspagarDataGridView.DoubleClick += new System.EventHandler(this.tb_contaspagarDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_conta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_conta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 580;
            // 
            // frmPesquisaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_contaspagarDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.pesquisarTextBox);
            this.Name = "frmPesquisaContasPagar";
            this.Text = "frmPesquisaContasPagar";
            this.Load += new System.EventHandler(this.frmPesquisaContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaspagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaspagarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox pesquisarTextBox;
        private BDCadastroDataSet bDCadastroDataSet;
        private System.Windows.Forms.BindingSource tb_contaspagarBindingSource;
        private BDCadastroDataSetTableAdapters.tb_contaspagarTableAdapter tb_contaspagarTableAdapter;
        private BDCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_contaspagarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}