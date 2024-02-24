namespace WindowsFormsApp1
{
    partial class Form_Cadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Fornecedor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpaCampos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_urlImage = new System.Windows.Forms.TextBox();
            this.btn_pegaUrl = new System.Windows.Forms.Button();
            this.pictureBoxImageProduto = new System.Windows.Forms.PictureBox();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_insereProduto = new System.Windows.Forms.Button();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeProduto = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_minQtd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_qtd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewCadastroProdutos = new Krypton.Toolkit.KryptonDataGridView();
            this.openFileDialogIsertImageProduct = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduto)).BeginInit();
            this.panel_gerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCadastroProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Fornecedor);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel_gerencia);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.rtb_desc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_marca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nomeProduto);
            this.groupBox1.Controls.Add(this.cb_tipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_minQtd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nud_qtd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iserir produtos no estoque";
            // 
            // cb_Fornecedor
            // 
            this.cb_Fornecedor.FormattingEnabled = true;
            this.cb_Fornecedor.Location = new System.Drawing.Point(10, 38);
            this.cb_Fornecedor.Name = "cb_Fornecedor";
            this.cb_Fornecedor.Size = new System.Drawing.Size(245, 23);
            this.cb_Fornecedor.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_limpaCampos);
            this.panel1.Location = new System.Drawing.Point(10, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 40);
            this.panel1.TabIndex = 21;
            // 
            // btn_limpaCampos
            // 
            this.btn_limpaCampos.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_limpaCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_limpaCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpaCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpaCampos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpaCampos.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_limpaCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpaCampos.Location = new System.Drawing.Point(-5, -5);
            this.btn_limpaCampos.Name = "btn_limpaCampos";
            this.btn_limpaCampos.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_limpaCampos.Size = new System.Drawing.Size(144, 50);
            this.btn_limpaCampos.TabIndex = 9;
            this.btn_limpaCampos.Text = "        Limpar campos";
            this.btn_limpaCampos.UseVisualStyleBackColor = false;
            this.btn_limpaCampos.MouseEnter += new System.EventHandler(this.btn_limpaCampos_MouseEnter);
            this.btn_limpaCampos.MouseLeave += new System.EventHandler(this.btn_limpaCampos_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tb_urlImage);
            this.groupBox3.Controls.Add(this.btn_pegaUrl);
            this.groupBox3.Controls.Add(this.pictureBoxImageProduto);
            this.groupBox3.Location = new System.Drawing.Point(830, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 226);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Escolher imagem para o produto:";
            // 
            // tb_urlImage
            // 
            this.tb_urlImage.Location = new System.Drawing.Point(9, 40);
            this.tb_urlImage.Name = "tb_urlImage";
            this.tb_urlImage.Size = new System.Drawing.Size(303, 21);
            this.tb_urlImage.TabIndex = 17;
            // 
            // btn_pegaUrl
            // 
            this.btn_pegaUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pegaUrl.Location = new System.Drawing.Point(313, 39);
            this.btn_pegaUrl.Name = "btn_pegaUrl";
            this.btn_pegaUrl.Size = new System.Drawing.Size(32, 23);
            this.btn_pegaUrl.TabIndex = 18;
            this.btn_pegaUrl.Text = "...";
            this.btn_pegaUrl.UseVisualStyleBackColor = true;
            this.btn_pegaUrl.Click += new System.EventHandler(this.btn_pegaUrl_Click);
            // 
            // pictureBoxImageProduto
            // 
            this.pictureBoxImageProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageProduto.Location = new System.Drawing.Point(9, 67);
            this.pictureBoxImageProduto.Name = "pictureBoxImageProduto";
            this.pictureBoxImageProduto.Size = new System.Drawing.Size(215, 153);
            this.pictureBoxImageProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageProduto.TabIndex = 19;
            this.pictureBoxImageProduto.TabStop = false;
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_insereProduto);
            this.panel_gerencia.Location = new System.Drawing.Point(318, 197);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 20;
            // 
            // btn_insereProduto
            // 
            this.btn_insereProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_insereProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_insereProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insereProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insereProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insereProduto.Image = global::WindowsFormsApp1.Properties.Resources.open_box;
            this.btn_insereProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insereProduto.Location = new System.Drawing.Point(-5, -5);
            this.btn_insereProduto.Name = "btn_insereProduto";
            this.btn_insereProduto.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_insereProduto.Size = new System.Drawing.Size(159, 50);
            this.btn_insereProduto.TabIndex = 9;
            this.btn_insereProduto.Text = "        Inserir Produto";
            this.btn_insereProduto.UseVisualStyleBackColor = false;
            this.btn_insereProduto.MouseEnter += new System.EventHandler(this.btn_insereProduto_MouseEnter);
            this.btn_insereProduto.MouseLeave += new System.EventHandler(this.btn_insereProduto_MouseLeave);
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(475, 38);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(245, 23);
            this.cb_categoria.TabIndex = 7;
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(475, 128);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(312, 109);
            this.rtb_desc.TabIndex = 9;
            this.rtb_desc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria do produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição simples do produto:";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(10, 128);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(245, 21);
            this.tb_marca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // tb_nomeProduto
            // 
            this.tb_nomeProduto.Location = new System.Drawing.Point(10, 84);
            this.tb_nomeProduto.Name = "tb_nomeProduto";
            this.tb_nomeProduto.Size = new System.Drawing.Size(245, 21);
            this.tb_nomeProduto.TabIndex = 3;
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(475, 82);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(245, 23);
            this.cb_tipo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do produto:";
            // 
            // nud_minQtd
            // 
            this.nud_minQtd.Location = new System.Drawing.Point(265, 84);
            this.nud_minQtd.Name = "nud_minQtd";
            this.nud_minQtd.Size = new System.Drawing.Size(120, 21);
            this.nud_minQtd.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Típo do material:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade mínima em estoque:";
            // 
            // nud_qtd
            // 
            this.nud_qtd.Location = new System.Drawing.Point(265, 40);
            this.nud_qtd.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_qtd.Name = "nud_qtd";
            this.nud_qtd.Size = new System.Drawing.Size(120, 21);
            this.nud_qtd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade do produto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 40);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(521, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cadastro de produtos";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonDataGridViewCadastroProdutos);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1193, 372);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // kryptonDataGridViewCadastroProdutos
            // 
            this.kryptonDataGridViewCadastroProdutos.AllowUserToAddRows = false;
            this.kryptonDataGridViewCadastroProdutos.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewCadastroProdutos.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewCadastroProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewCadastroProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonDataGridViewCadastroProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewCadastroProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewCadastroProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewCadastroProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewCadastroProdutos.Location = new System.Drawing.Point(3, 16);
            this.kryptonDataGridViewCadastroProdutos.MultiSelect = false;
            this.kryptonDataGridViewCadastroProdutos.Name = "kryptonDataGridViewCadastroProdutos";
            this.kryptonDataGridViewCadastroProdutos.RowHeadersVisible = false;
            this.kryptonDataGridViewCadastroProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewCadastroProdutos.Size = new System.Drawing.Size(1187, 353);
            this.kryptonDataGridViewCadastroProdutos.TabIndex = 1;
            // 
            // openFileDialogIsertImageProduct
            // 
            this.openFileDialogIsertImageProduct.FileName = "openFileDialog1";
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.Form_Cadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduto)).EndInit();
            this.panel_gerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_minQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCadastroProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_minQtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_qtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxImageProduto;
        private System.Windows.Forms.Button btn_pegaUrl;
        private System.Windows.Forms.TextBox tb_urlImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_insereProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewCadastroProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_limpaCampos;
        private System.Windows.Forms.ComboBox cb_Fornecedor;
        private System.Windows.Forms.OpenFileDialog openFileDialogIsertImageProduct;
    }
}