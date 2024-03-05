namespace WindowsFormsApp1
{
    partial class Form_Gerencia_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gerencia_Estoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_buscaPorNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_itemEstoque = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewGerenciaProdutos = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_idProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_salvarAlteracao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.nud_qtd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_Fornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_minQtd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMostraItem = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_adicionaImagem = new System.Windows.Forms.Button();
            this.openFileDialogAlterProduct = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewGerenciaProdutos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 40);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(567, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar estoque";
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
            this.groupBox2.Controls.Add(this.tb_buscaPorNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efetuar buscas";
            // 
            // tb_buscaPorNome
            // 
            this.tb_buscaPorNome.Location = new System.Drawing.Point(6, 37);
            this.tb_buscaPorNome.Name = "tb_buscaPorNome";
            this.tb_buscaPorNome.Size = new System.Drawing.Size(495, 21);
            this.tb_buscaPorNome.TabIndex = 1;
            this.tb_buscaPorNome.TextChanged += new System.EventHandler(this.tb_buscaPorNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar por nome:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_itemEstoque);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(788, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 76);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Total de itens registrado no estoque";
            // 
            // tb_itemEstoque
            // 
            this.tb_itemEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemEstoque.Location = new System.Drawing.Point(6, 30);
            this.tb_itemEstoque.Name = "tb_itemEstoque";
            this.tb_itemEstoque.Size = new System.Drawing.Size(233, 28);
            this.tb_itemEstoque.TabIndex = 1;
            this.tb_itemEstoque.Text = "...";
            this.tb_itemEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonDataGridViewGerenciaProdutos);
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1272, 343);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clique duas vezes no item para mais detalhes";
            // 
            // kryptonDataGridViewGerenciaProdutos
            // 
            this.kryptonDataGridViewGerenciaProdutos.AllowUserToAddRows = false;
            this.kryptonDataGridViewGerenciaProdutos.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewGerenciaProdutos.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewGerenciaProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewGerenciaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewGerenciaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewGerenciaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewGerenciaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewGerenciaProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewGerenciaProdutos.Location = new System.Drawing.Point(3, 16);
            this.kryptonDataGridViewGerenciaProdutos.MultiSelect = false;
            this.kryptonDataGridViewGerenciaProdutos.Name = "kryptonDataGridViewGerenciaProdutos";
            this.kryptonDataGridViewGerenciaProdutos.RowHeadersVisible = false;
            this.kryptonDataGridViewGerenciaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewGerenciaProdutos.Size = new System.Drawing.Size(1266, 324);
            this.kryptonDataGridViewGerenciaProdutos.TabIndex = 1;
            this.kryptonDataGridViewGerenciaProdutos.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewGerenciaProdutos_SelectionChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_idProduto);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cb_categoria);
            this.groupBox5.Controls.Add(this.rtb_desc);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.nud_qtd);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cb_tipo);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cb_Fornecedor);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tb_nomeProduto);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nud_minQtd);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.tb_marca);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1021, 209);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados completos do produto";
            // 
            // tb_idProduto
            // 
            this.tb_idProduto.Location = new System.Drawing.Point(9, 35);
            this.tb_idProduto.Name = "tb_idProduto";
            this.tb_idProduto.ReadOnly = true;
            this.tb_idProduto.Size = new System.Drawing.Size(145, 21);
            this.tb_idProduto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Produto:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Location = new System.Drawing.Point(262, 75);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(245, 23);
            this.cb_categoria.TabIndex = 9;
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(703, 33);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(306, 112);
            this.rtb_desc.TabIndex = 11;
            this.rtb_desc.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Categoria do produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(700, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Descrição simples do produto:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_salvarAlteracao);
            this.panel2.Location = new System.Drawing.Point(736, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 40);
            this.panel2.TabIndex = 22;
            // 
            // btn_salvarAlteracao
            // 
            this.btn_salvarAlteracao.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_salvarAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_salvarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarAlteracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvarAlteracao.Image = global::WindowsFormsApp1.Properties.Resources.diskette;
            this.btn_salvarAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvarAlteracao.Location = new System.Drawing.Point(-5, -5);
            this.btn_salvarAlteracao.Name = "btn_salvarAlteracao";
            this.btn_salvarAlteracao.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_salvarAlteracao.Size = new System.Drawing.Size(159, 50);
            this.btn_salvarAlteracao.TabIndex = 14;
            this.btn_salvarAlteracao.Text = "        Salvar alterações";
            this.btn_salvarAlteracao.UseVisualStyleBackColor = false;
            this.btn_salvarAlteracao.Click += new System.EventHandler(this.btn_salvarAlteracao_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_removeItem);
            this.panel3.Location = new System.Drawing.Point(898, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 40);
            this.panel3.TabIndex = 23;
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_removeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_removeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_removeItem.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btn_removeItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeItem.Location = new System.Drawing.Point(-6, -5);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_removeItem.Size = new System.Drawing.Size(122, 50);
            this.btn_removeItem.TabIndex = 15;
            this.btn_removeItem.Text = "      Remover";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // nud_qtd
            // 
            this.nud_qtd.Location = new System.Drawing.Point(513, 37);
            this.nud_qtd.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_qtd.Name = "nud_qtd";
            this.nud_qtd.Size = new System.Drawing.Size(120, 21);
            this.nud_qtd.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantidade do produto:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(262, 122);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(245, 23);
            this.cb_tipo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Típo do material:";
            // 
            // cb_Fornecedor
            // 
            this.cb_Fornecedor.FormattingEnabled = true;
            this.cb_Fornecedor.Location = new System.Drawing.Point(9, 78);
            this.cb_Fornecedor.Name = "cb_Fornecedor";
            this.cb_Fornecedor.Size = new System.Drawing.Size(245, 23);
            this.cb_Fornecedor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantidade mínima em estoque:";
            // 
            // tb_nomeProduto
            // 
            this.tb_nomeProduto.Location = new System.Drawing.Point(9, 124);
            this.tb_nomeProduto.Name = "tb_nomeProduto";
            this.tb_nomeProduto.Size = new System.Drawing.Size(245, 21);
            this.tb_nomeProduto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nome do produto:";
            // 
            // nud_minQtd
            // 
            this.nud_minQtd.Location = new System.Drawing.Point(513, 81);
            this.nud_minQtd.Name = "nud_minQtd";
            this.nud_minQtd.Size = new System.Drawing.Size(120, 21);
            this.nud_minQtd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fornecedor:";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(262, 36);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(245, 21);
            this.tb_marca.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Marca:";
            // 
            // pictureBoxMostraItem
            // 
            this.pictureBoxMostraItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMostraItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostraItem.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxMostraItem.Name = "pictureBoxMostraItem";
            this.pictureBoxMostraItem.Size = new System.Drawing.Size(215, 153);
            this.pictureBoxMostraItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostraItem.TabIndex = 40;
            this.pictureBoxMostraItem.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.panel4);
            this.groupBox6.Controls.Add(this.pictureBoxMostraItem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1036, 51);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 286);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Imagem do produto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(65, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 42);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_adicionaImagem);
            this.panel4.Location = new System.Drawing.Point(41, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 40);
            this.panel4.TabIndex = 41;
            // 
            // btn_adicionaImagem
            // 
            this.btn_adicionaImagem.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_adicionaImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_adicionaImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionaImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionaImagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_adicionaImagem.Image = global::WindowsFormsApp1.Properties.Resources.image;
            this.btn_adicionaImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionaImagem.Location = new System.Drawing.Point(-5, -5);
            this.btn_adicionaImagem.Name = "btn_adicionaImagem";
            this.btn_adicionaImagem.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_adicionaImagem.Size = new System.Drawing.Size(159, 50);
            this.btn_adicionaImagem.TabIndex = 12;
            this.btn_adicionaImagem.Text = "        Alterar imagem";
            this.btn_adicionaImagem.UseVisualStyleBackColor = false;
            this.btn_adicionaImagem.Click += new System.EventHandler(this.btn_adicionaImagem_Click);
            // 
            // openFileDialogAlterProduct
            // 
            this.openFileDialogAlterProduct.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(539, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 190);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Gerencia_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Gerencia_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar estoque";
            this.Load += new System.EventHandler(this.Form_Gerencia_Estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewGerenciaProdutos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label tb_itemEstoque;
        private System.Windows.Forms.TextBox tb_buscaPorNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewGerenciaProdutos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_salvarAlteracao;
        private System.Windows.Forms.ComboBox cb_Fornecedor;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_minQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_qtd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxMostraItem;
        private System.Windows.Forms.TextBox tb_idProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_adicionaImagem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialogAlterProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}