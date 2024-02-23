namespace WindowsFormsApp1
{
    partial class Form_Categoria
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_idCategoriaRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeCategoriaRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewCategoria = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_nomeCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_removeCategoria = new System.Windows.Forms.Button();
            this.btn_addCategoria = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.tb_idCategoriaRemove);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_nomeCategoriaRemove);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 71);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remover categoria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_removeCategoria);
            this.panel1.Location = new System.Drawing.Point(317, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 35);
            this.panel1.TabIndex = 41;
            // 
            // tb_idCategoriaRemove
            // 
            this.tb_idCategoriaRemove.Location = new System.Drawing.Point(7, 38);
            this.tb_idCategoriaRemove.Name = "tb_idCategoriaRemove";
            this.tb_idCategoriaRemove.ReadOnly = true;
            this.tb_idCategoriaRemove.Size = new System.Drawing.Size(70, 20);
            this.tb_idCategoriaRemove.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // tb_nomeCategoriaRemove
            // 
            this.tb_nomeCategoriaRemove.Location = new System.Drawing.Point(86, 38);
            this.tb_nomeCategoriaRemove.Name = "tb_nomeCategoriaRemove";
            this.tb_nomeCategoriaRemove.ReadOnly = true;
            this.tb_nomeCategoriaRemove.Size = new System.Drawing.Size(225, 20);
            this.tb_nomeCategoriaRemove.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da categoria:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonDataGridViewCategoria);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 214);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de categorias existentes";
            // 
            // kryptonDataGridViewCategoria
            // 
            this.kryptonDataGridViewCategoria.AllowUserToAddRows = false;
            this.kryptonDataGridViewCategoria.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewCategoria.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewCategoria.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewCategoria.MultiSelect = false;
            this.kryptonDataGridViewCategoria.Name = "kryptonDataGridViewCategoria";
            this.kryptonDataGridViewCategoria.RowHeadersVisible = false;
            this.kryptonDataGridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewCategoria.Size = new System.Drawing.Size(434, 194);
            this.kryptonDataGridViewCategoria.TabIndex = 1;
            this.kryptonDataGridViewCategoria.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewCategoria_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.tb_nomeCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar categoria";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_addCategoria);
            this.panel5.Location = new System.Drawing.Point(314, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 35);
            this.panel5.TabIndex = 40;
            // 
            // tb_nomeCategoria
            // 
            this.tb_nomeCategoria.Location = new System.Drawing.Point(7, 40);
            this.tb_nomeCategoria.Name = "tb_nomeCategoria";
            this.tb_nomeCategoria.Size = new System.Drawing.Size(298, 21);
            this.tb_nomeCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da categoria:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 40);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(147, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Criar categoria de produto";
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
            // btn_removeCategoria
            // 
            this.btn_removeCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_removeCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_removeCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_removeCategoria.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btn_removeCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeCategoria.Location = new System.Drawing.Point(-3, -7);
            this.btn_removeCategoria.Name = "btn_removeCategoria";
            this.btn_removeCategoria.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_removeCategoria.Size = new System.Drawing.Size(120, 50);
            this.btn_removeCategoria.TabIndex = 10;
            this.btn_removeCategoria.Text = "        Excluir";
            this.btn_removeCategoria.UseVisualStyleBackColor = false;
            this.btn_removeCategoria.Click += new System.EventHandler(this.btn_removeCategoria_Click);
            // 
            // btn_addCategoria
            // 
            this.btn_addCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_addCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_addCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addCategoria.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.btn_addCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCategoria.Location = new System.Drawing.Point(-3, -7);
            this.btn_addCategoria.Name = "btn_addCategoria";
            this.btn_addCategoria.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_addCategoria.Size = new System.Drawing.Size(120, 50);
            this.btn_addCategoria.TabIndex = 10;
            this.btn_addCategoria.Text = "        Adicionar";
            this.btn_addCategoria.UseVisualStyleBackColor = false;
            this.btn_addCategoria.Click += new System.EventHandler(this.btn_addStatus_Click);
            // 
            // Form_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Categorias de produtos";
            this.Load += new System.EventHandler(this.Form_Categoria_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_removeCategoria;
        private System.Windows.Forms.TextBox tb_idCategoriaRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeCategoriaRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_addCategoria;
        private System.Windows.Forms.TextBox tb_nomeCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}