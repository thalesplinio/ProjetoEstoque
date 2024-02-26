namespace WindowsFormsApp1
{
    partial class Listar_Produtos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewListaProdutos = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_idProduto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_mostraQtd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.tb_buscaPorNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_BuscaCategoria = new System.Windows.Forms.ComboBox();
            this.cb_BuscaToipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMostraItem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(476, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Todos os produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 622);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos os materiais";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonDataGridViewListaProdutos);
            this.groupBox3.Location = new System.Drawing.Point(6, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1178, 398);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clique duas vezes no item para mais detalhes";
            // 
            // kryptonDataGridViewListaProdutos
            // 
            this.kryptonDataGridViewListaProdutos.AllowUserToAddRows = false;
            this.kryptonDataGridViewListaProdutos.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewListaProdutos.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewListaProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewListaProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewListaProdutos.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewListaProdutos.MultiSelect = false;
            this.kryptonDataGridViewListaProdutos.Name = "kryptonDataGridViewListaProdutos";
            this.kryptonDataGridViewListaProdutos.RowHeadersVisible = false;
            this.kryptonDataGridViewListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewListaProdutos.Size = new System.Drawing.Size(1172, 378);
            this.kryptonDataGridViewListaProdutos.TabIndex = 1;
            this.kryptonDataGridViewListaProdutos.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewListaProdutos_SelectionChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_idProduto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_mostraQtd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kryptonTextBox1);
            this.groupBox2.Controls.Add(this.pictureBoxMostraItem);
            this.groupBox2.Controls.Add(this.tb_buscaPorNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_BuscaCategoria);
            this.groupBox2.Controls.Add(this.cb_BuscaToipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efetuar buscas";
            // 
            // lb_idProduto
            // 
            this.lb_idProduto.AutoSize = true;
            this.lb_idProduto.Location = new System.Drawing.Point(997, 15);
            this.lb_idProduto.Name = "lb_idProduto";
            this.lb_idProduto.Size = new System.Drawing.Size(16, 15);
            this.lb_idProduto.TabIndex = 23;
            this.lb_idProduto.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID Produto:";
            // 
            // lb_mostraQtd
            // 
            this.lb_mostraQtd.AutoSize = true;
            this.lb_mostraQtd.Location = new System.Drawing.Point(226, 158);
            this.lb_mostraQtd.Name = "lb_mostraQtd";
            this.lb_mostraQtd.Size = new System.Drawing.Size(16, 15);
            this.lb_mostraQtd.TabIndex = 21;
            this.lb_mostraQtd.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantidade total de itens em estoque:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(6, 64);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(879, 59);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 15F;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 8;
            // 
            // tb_buscaPorNome
            // 
            this.tb_buscaPorNome.Location = new System.Drawing.Point(6, 37);
            this.tb_buscaPorNome.Name = "tb_buscaPorNome";
            this.tb_buscaPorNome.Size = new System.Drawing.Size(341, 21);
            this.tb_buscaPorNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar por Categoria:";
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
            // cb_BuscaCategoria
            // 
            this.cb_BuscaCategoria.FormattingEnabled = true;
            this.cb_BuscaCategoria.Location = new System.Drawing.Point(353, 35);
            this.cb_BuscaCategoria.Name = "cb_BuscaCategoria";
            this.cb_BuscaCategoria.Size = new System.Drawing.Size(232, 23);
            this.cb_BuscaCategoria.TabIndex = 1;
            // 
            // cb_BuscaToipo
            // 
            this.cb_BuscaToipo.FormattingEnabled = true;
            this.cb_BuscaToipo.Location = new System.Drawing.Point(591, 35);
            this.cb_BuscaToipo.Name = "cb_BuscaToipo";
            this.cb_BuscaToipo.Size = new System.Drawing.Size(232, 23);
            this.cb_BuscaToipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecionar por tipo:";
            // 
            // pictureBoxMostraItem
            // 
            this.pictureBoxMostraItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostraItem.Location = new System.Drawing.Point(926, 33);
            this.pictureBoxMostraItem.Name = "pictureBoxMostraItem";
            this.pictureBoxMostraItem.Size = new System.Drawing.Size(215, 153);
            this.pictureBoxMostraItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostraItem.TabIndex = 19;
            this.pictureBoxMostraItem.TabStop = false;
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
            // Listar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar_Produtos";
            this.Load += new System.EventHandler(this.Listar_Produtos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_buscaPorNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_BuscaCategoria;
        private System.Windows.Forms.ComboBox cb_BuscaToipo;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.PictureBox pictureBoxMostraItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewListaProdutos;
        private System.Windows.Forms.Label lb_mostraQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_idProduto;
    }
}