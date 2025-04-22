namespace WindowsFormsApp1
{
    partial class FormRetirarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetirarProduto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewRetiraProdutos = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_buscaPorNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lb_qtdProdutos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_descRetirada = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_valorRetirada = new System.Windows.Forms.TextBox();
            this.labelTituloValorRetirada = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMostraProduto = new System.Windows.Forms.PictureBox();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_retiraProduto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_descProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_tipoProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_categoriaProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_quantidadeMinima = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_marcaProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nomeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_idFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_idProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewRetiraProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraProduto)).BeginInit();
            this.panel_gerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1215, 40);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(476, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fazer retirada de produtos";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonDataGridViewRetiraProdutos);
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1178, 222);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clique duas vezes no item para mais detalhes";
            // 
            // kryptonDataGridViewRetiraProdutos
            // 
            this.kryptonDataGridViewRetiraProdutos.AllowUserToAddRows = false;
            this.kryptonDataGridViewRetiraProdutos.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewRetiraProdutos.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewRetiraProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewRetiraProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewRetiraProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewRetiraProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewRetiraProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewRetiraProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewRetiraProdutos.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewRetiraProdutos.MultiSelect = false;
            this.kryptonDataGridViewRetiraProdutos.Name = "kryptonDataGridViewRetiraProdutos";
            this.kryptonDataGridViewRetiraProdutos.RowHeadersVisible = false;
            this.kryptonDataGridViewRetiraProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewRetiraProdutos.Size = new System.Drawing.Size(1172, 202);
            this.kryptonDataGridViewRetiraProdutos.TabIndex = 1;
            this.kryptonDataGridViewRetiraProdutos.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewRetiraProdutos_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_buscaPorNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 74);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // tb_buscaPorNome
            // 
            this.tb_buscaPorNome.Location = new System.Drawing.Point(6, 40);
            this.tb_buscaPorNome.Name = "tb_buscaPorNome";
            this.tb_buscaPorNome.Size = new System.Drawing.Size(357, 21);
            this.tb_buscaPorNome.TabIndex = 30;
            this.tb_buscaPorNome.TextChanged += new System.EventHandler(this.tb_buscaPorNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Buscar por nome:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lb_qtdProdutos);
            this.groupBox7.Location = new System.Drawing.Point(386, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(228, 74);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Quantidade de produtos no estoque";
            // 
            // lb_qtdProdutos
            // 
            this.lb_qtdProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdProdutos.Location = new System.Drawing.Point(6, 30);
            this.lb_qtdProdutos.Name = "lb_qtdProdutos";
            this.lb_qtdProdutos.Size = new System.Drawing.Size(216, 20);
            this.lb_qtdProdutos.TabIndex = 0;
            this.lb_qtdProdutos.Text = "...";
            this.lb_qtdProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 622);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirada de produtos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_descRetirada);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.tb_valorRetirada);
            this.groupBox6.Controls.Add(this.labelTituloValorRetirada);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.panel_gerencia);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Location = new System.Drawing.Point(665, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(515, 287);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Retirar Produto";
            // 
            // tb_descRetirada
            // 
            this.tb_descRetirada.Location = new System.Drawing.Point(236, 83);
            this.tb_descRetirada.Multiline = true;
            this.tb_descRetirada.Name = "tb_descRetirada";
            this.tb_descRetirada.Size = new System.Drawing.Size(268, 109);
            this.tb_descRetirada.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Descrição simples do produto:";
            // 
            // tb_valorRetirada
            // 
            this.tb_valorRetirada.Location = new System.Drawing.Point(236, 40);
            this.tb_valorRetirada.Name = "tb_valorRetirada";
            this.tb_valorRetirada.Size = new System.Drawing.Size(268, 21);
            this.tb_valorRetirada.TabIndex = 22;
            // 
            // labelTituloValorRetirada
            // 
            this.labelTituloValorRetirada.AutoSize = true;
            this.labelTituloValorRetirada.Location = new System.Drawing.Point(233, 21);
            this.labelTituloValorRetirada.Name = "labelTituloValorRetirada";
            this.labelTituloValorRetirada.Size = new System.Drawing.Size(147, 15);
            this.labelTituloValorRetirada.TabIndex = 21;
            this.labelTituloValorRetirada.Text = "Quantidade para retirada:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxMostraProduto);
            this.groupBox5.Location = new System.Drawing.Point(6, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 186);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Imagem do produto";
            // 
            // pictureBoxMostraProduto
            // 
            this.pictureBoxMostraProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMostraProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostraProduto.Location = new System.Drawing.Point(5, 29);
            this.pictureBoxMostraProduto.Name = "pictureBoxMostraProduto";
            this.pictureBoxMostraProduto.Size = new System.Drawing.Size(215, 153);
            this.pictureBoxMostraProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostraProduto.TabIndex = 20;
            this.pictureBoxMostraProduto.TabStop = false;
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_retiraProduto);
            this.panel_gerencia.Location = new System.Drawing.Point(353, 232);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 19;
            // 
            // btn_retiraProduto
            // 
            this.btn_retiraProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_retiraProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_retiraProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retiraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retiraProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_retiraProduto.Image = global::WindowsFormsApp1.Properties.Resources.remove;
            this.btn_retiraProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retiraProduto.Location = new System.Drawing.Point(-5, -5);
            this.btn_retiraProduto.Name = "btn_retiraProduto";
            this.btn_retiraProduto.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_retiraProduto.Size = new System.Drawing.Size(159, 50);
            this.btn_retiraProduto.TabIndex = 6;
            this.btn_retiraProduto.Text = "        Retirar produto";
            this.btn_retiraProduto.UseVisualStyleBackColor = false;
            this.btn_retiraProduto.Click += new System.EventHandler(this.btn_retiraProduto_Click);
            this.btn_retiraProduto.MouseEnter += new System.EventHandler(this.btn_retiraProduto_MouseEnter);
            this.btn_retiraProduto.MouseLeave += new System.EventHandler(this.btn_retiraProduto_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(262, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 190);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_descProduto);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tb_tipoProduto);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_categoriaProduto);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_quantidadeMinima);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tb_quantidade);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tb_marcaProduto);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tb_nomeProduto);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tb_idFornecedor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tb_idProduto);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 287);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conferir dados para retirada";
            // 
            // tb_descProduto
            // 
            this.tb_descProduto.Location = new System.Drawing.Point(289, 128);
            this.tb_descProduto.Multiline = true;
            this.tb_descProduto.Name = "tb_descProduto";
            this.tb_descProduto.ReadOnly = true;
            this.tb_descProduto.Size = new System.Drawing.Size(359, 144);
            this.tb_descProduto.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Descrição simples do produto:";
            // 
            // tb_tipoProduto
            // 
            this.tb_tipoProduto.Location = new System.Drawing.Point(10, 251);
            this.tb_tipoProduto.Name = "tb_tipoProduto";
            this.tb_tipoProduto.ReadOnly = true;
            this.tb_tipoProduto.Size = new System.Drawing.Size(268, 21);
            this.tb_tipoProduto.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tipo de produto:";
            // 
            // tb_categoriaProduto
            // 
            this.tb_categoriaProduto.Location = new System.Drawing.Point(10, 211);
            this.tb_categoriaProduto.Name = "tb_categoriaProduto";
            this.tb_categoriaProduto.ReadOnly = true;
            this.tb_categoriaProduto.Size = new System.Drawing.Size(268, 21);
            this.tb_categoriaProduto.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Categoria do produto:";
            // 
            // tb_quantidadeMinima
            // 
            this.tb_quantidadeMinima.Location = new System.Drawing.Point(289, 85);
            this.tb_quantidadeMinima.Name = "tb_quantidadeMinima";
            this.tb_quantidadeMinima.ReadOnly = true;
            this.tb_quantidadeMinima.Size = new System.Drawing.Size(268, 21);
            this.tb_quantidadeMinima.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantidade mínima em estoque:";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(289, 40);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.ReadOnly = true;
            this.tb_quantidade.Size = new System.Drawing.Size(268, 21);
            this.tb_quantidade.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantidade em estoque:";
            // 
            // tb_marcaProduto
            // 
            this.tb_marcaProduto.Location = new System.Drawing.Point(10, 171);
            this.tb_marcaProduto.Name = "tb_marcaProduto";
            this.tb_marcaProduto.ReadOnly = true;
            this.tb_marcaProduto.Size = new System.Drawing.Size(273, 21);
            this.tb_marcaProduto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marca do produto:";
            // 
            // tb_nomeProduto
            // 
            this.tb_nomeProduto.Location = new System.Drawing.Point(10, 128);
            this.tb_nomeProduto.Name = "tb_nomeProduto";
            this.tb_nomeProduto.ReadOnly = true;
            this.tb_nomeProduto.Size = new System.Drawing.Size(273, 21);
            this.tb_nomeProduto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome do produto:";
            // 
            // tb_idFornecedor
            // 
            this.tb_idFornecedor.Location = new System.Drawing.Point(10, 85);
            this.tb_idFornecedor.Name = "tb_idFornecedor";
            this.tb_idFornecedor.ReadOnly = true;
            this.tb_idFornecedor.Size = new System.Drawing.Size(273, 21);
            this.tb_idFornecedor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fornecedor do produto:";
            // 
            // tb_idProduto
            // 
            this.tb_idProduto.Location = new System.Drawing.Point(10, 40);
            this.tb_idProduto.Name = "tb_idProduto";
            this.tb_idProduto.ReadOnly = true;
            this.tb_idProduto.Size = new System.Drawing.Size(273, 21);
            this.tb_idProduto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID do produto:";
            // 
            // Form_Retirar_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Retirar_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirada de Produtos";
            this.Load += new System.EventHandler(this.Form_Retirar_Produto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewRetiraProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraProduto)).EndInit();
            this.panel_gerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_buscaPorNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewRetiraProdutos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lb_qtdProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_descRetirada;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_valorRetirada;
        private System.Windows.Forms.Label labelTituloValorRetirada;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxMostraProduto;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_retiraProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_descProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_tipoProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_categoriaProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_quantidadeMinima;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_marcaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nomeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_idFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_idProduto;
        private System.Windows.Forms.Label label4;
    }
}