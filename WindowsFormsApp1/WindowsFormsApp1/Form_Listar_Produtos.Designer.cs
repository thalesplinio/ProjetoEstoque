namespace WindowsFormsApp1
{
    partial class Form_Listar_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listar_Produtos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewListaProdutos = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_itemEstoque = new System.Windows.Forms.Label();
            this.tb_buscaPorNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostraItem = new System.Windows.Forms.PictureBox();
            this.tb_idProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1178, 391);
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
            this.kryptonDataGridViewListaProdutos.Size = new System.Drawing.Size(1172, 371);
            this.kryptonDataGridViewListaProdutos.TabIndex = 1;
            this.kryptonDataGridViewListaProdutos.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewListaProdutos_SelectionChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_buscaPorNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efetuar buscas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_itemEstoque);
            this.groupBox4.Location = new System.Drawing.Point(6, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 69);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Total de itens registrado no estoque";
            // 
            // tb_itemEstoque
            // 
            this.tb_itemEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemEstoque.Location = new System.Drawing.Point(6, 21);
            this.tb_itemEstoque.Name = "tb_itemEstoque";
            this.tb_itemEstoque.Size = new System.Drawing.Size(257, 28);
            this.tb_itemEstoque.TabIndex = 1;
            this.tb_itemEstoque.Text = "...";
            this.tb_itemEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_buscaPorNome
            // 
            this.tb_buscaPorNome.Location = new System.Drawing.Point(6, 37);
            this.tb_buscaPorNome.Name = "tb_buscaPorNome";
            this.tb_buscaPorNome.Size = new System.Drawing.Size(362, 21);
            this.tb_buscaPorNome.TabIndex = 5;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(723, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 190);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxMostraItem
            // 
            this.pictureBoxMostraItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMostraItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostraItem.Location = new System.Drawing.Point(6, 40);
            this.pictureBoxMostraItem.Name = "pictureBoxMostraItem";
            this.pictureBoxMostraItem.Size = new System.Drawing.Size(215, 153);
            this.pictureBoxMostraItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostraItem.TabIndex = 25;
            this.pictureBoxMostraItem.TabStop = false;
            // 
            // tb_idProduto
            // 
            this.tb_idProduto.Location = new System.Drawing.Point(76, 16);
            this.tb_idProduto.Name = "tb_idProduto";
            this.tb_idProduto.ReadOnly = true;
            this.tb_idProduto.Size = new System.Drawing.Size(145, 21);
            this.tb_idProduto.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID Produto:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxMostraItem);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tb_idProduto);
            this.groupBox5.Location = new System.Drawing.Point(948, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 199);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Imagem do produto";
            // 
            // Form_Listar_Produtos
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
            this.Name = "Form_Listar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Produtos";
            this.Load += new System.EventHandler(this.Listar_Produtos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewListaProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraItem)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_buscaPorNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewListaProdutos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label tb_itemEstoque;
        private System.Windows.Forms.PictureBox pictureBoxMostraItem;
        private System.Windows.Forms.TextBox tb_idProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}