namespace WindowsFormsApp1
{
    partial class FormRelatorioDeUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioDeUsuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_novoFornecedor = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_qtdInsertUsuario = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewListaProdutosRelatorioUsuario = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_buscaNomeUsuarioRelatorio = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialogPDF = new System.Windows.Forms.SaveFileDialog();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.lb_quantidadeInserida = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_gerencia.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutosRelatorioUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 40);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(549, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Relatório de usuários";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_quantidadeInserida);
            this.groupBox1.Controls.Add(this.lb_nomeUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel_gerencia);
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1304, 491);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar relatórios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quantidade inserida:";
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_novoFornecedor);
            this.panel_gerencia.Location = new System.Drawing.Point(1144, 42);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 29;
            // 
            // btn_novoFornecedor
            // 
            this.btn_novoFornecedor.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_novoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_novoFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_novoFornecedor.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_novoFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novoFornecedor.Location = new System.Drawing.Point(-5, -5);
            this.btn_novoFornecedor.Name = "btn_novoFornecedor";
            this.btn_novoFornecedor.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_novoFornecedor.Size = new System.Drawing.Size(159, 50);
            this.btn_novoFornecedor.TabIndex = 6;
            this.btn_novoFornecedor.Text = "        Salvar em PDF";
            this.btn_novoFornecedor.UseVisualStyleBackColor = false;
            this.btn_novoFornecedor.Click += new System.EventHandler(this.btn_novoFornecedor_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(369, 30);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(105, 15);
            this.label0.TabIndex = 28;
            this.label0.Text = "Nome de usuário:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_qtdInsertUsuario);
            this.groupBox4.Location = new System.Drawing.Point(653, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 55);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quantidade de produtos inseridos por esse usuário";
            // 
            // lb_qtdInsertUsuario
            // 
            this.lb_qtdInsertUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdInsertUsuario.Location = new System.Drawing.Point(6, 21);
            this.lb_qtdInsertUsuario.Name = "lb_qtdInsertUsuario";
            this.lb_qtdInsertUsuario.Size = new System.Drawing.Size(319, 31);
            this.lb_qtdInsertUsuario.TabIndex = 0;
            this.lb_qtdInsertUsuario.Text = "...";
            this.lb_qtdInsertUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonDataGridViewListaProdutosRelatorioUsuario);
            this.groupBox3.Location = new System.Drawing.Point(14, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1284, 399);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listagem";
            // 
            // kryptonDataGridViewListaProdutosRelatorioUsuario
            // 
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.AllowUserToAddRows = false;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.MultiSelect = false;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.Name = "kryptonDataGridViewListaProdutosRelatorioUsuario";
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.RowHeadersVisible = false;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.Size = new System.Drawing.Size(1278, 379);
            this.kryptonDataGridViewListaProdutosRelatorioUsuario.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_buscaNomeUsuarioRelatorio);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar relatório por nome de usuário";
            // 
            // tb_buscaNomeUsuarioRelatorio
            // 
            this.tb_buscaNomeUsuarioRelatorio.Location = new System.Drawing.Point(7, 21);
            this.tb_buscaNomeUsuarioRelatorio.Name = "tb_buscaNomeUsuarioRelatorio";
            this.tb_buscaNomeUsuarioRelatorio.Size = new System.Drawing.Size(343, 21);
            this.tb_buscaNomeUsuarioRelatorio.TabIndex = 0;
            this.tb_buscaNomeUsuarioRelatorio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(990, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 190);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(480, 30);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(16, 15);
            this.lb_nomeUsuario.TabIndex = 31;
            this.lb_nomeUsuario.Text = "...";
            // 
            // lb_quantidadeInserida
            // 
            this.lb_quantidadeInserida.AutoSize = true;
            this.lb_quantidadeInserida.Location = new System.Drawing.Point(496, 55);
            this.lb_quantidadeInserida.Name = "lb_quantidadeInserida";
            this.lb_quantidadeInserida.Size = new System.Drawing.Size(16, 15);
            this.lb_quantidadeInserida.TabIndex = 32;
            this.lb_quantidadeInserida.Text = "...";
            // 
            // Form_Relatorio_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Relatorio_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de usuários";
            this.Load += new System.EventHandler(this.Form_Relatorio_Usuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_gerencia.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutosRelatorioUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_buscaNomeUsuarioRelatorio;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewListaProdutosRelatorioUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_qtdInsertUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPDF;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_novoFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_quantidadeInserida;
        private System.Windows.Forms.Label lb_nomeUsuario;
    }
}