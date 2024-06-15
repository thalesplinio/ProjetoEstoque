namespace WindowsFormsApp1
{
    partial class Form_Tipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tipo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_tituloTipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_removeTipo = new System.Windows.Forms.Button();
            this.tb_idTipoRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeTipoRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewTipo = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_addTipo = new System.Windows.Forms.Button();
            this.tb_nomeTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.lb_tituloTipo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 40);
            this.panel2.TabIndex = 10;
            // 
            // lb_tituloTipo
            // 
            this.lb_tituloTipo.AutoSize = true;
            this.lb_tituloTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tituloTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tituloTipo.Location = new System.Drawing.Point(147, 9);
            this.lb_tituloTipo.Name = "lb_tituloTipo";
            this.lb_tituloTipo.Size = new System.Drawing.Size(198, 25);
            this.lb_tituloTipo.TabIndex = 3;
            this.lb_tituloTipo.Text = "Criar tipos de produto";
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
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.tb_idTipoRemove);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_nomeTipoRemove);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remover categoria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_removeTipo);
            this.panel1.Location = new System.Drawing.Point(317, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 35);
            this.panel1.TabIndex = 41;
            // 
            // btn_removeTipo
            // 
            this.btn_removeTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_removeTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_removeTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_removeTipo.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btn_removeTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeTipo.Location = new System.Drawing.Point(-3, -7);
            this.btn_removeTipo.Name = "btn_removeTipo";
            this.btn_removeTipo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_removeTipo.Size = new System.Drawing.Size(120, 50);
            this.btn_removeTipo.TabIndex = 10;
            this.btn_removeTipo.Text = "        Excluir";
            this.btn_removeTipo.UseVisualStyleBackColor = false;
            this.btn_removeTipo.Click += new System.EventHandler(this.btn_removeTipo_Click);
            this.btn_removeTipo.MouseEnter += new System.EventHandler(this.btn_removeTipo_MouseEnter);
            this.btn_removeTipo.MouseLeave += new System.EventHandler(this.btn_removeTipo_MouseLeave);
            // 
            // tb_idTipoRemove
            // 
            this.tb_idTipoRemove.Location = new System.Drawing.Point(7, 38);
            this.tb_idTipoRemove.Name = "tb_idTipoRemove";
            this.tb_idTipoRemove.ReadOnly = true;
            this.tb_idTipoRemove.Size = new System.Drawing.Size(70, 21);
            this.tb_idTipoRemove.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // tb_nomeTipoRemove
            // 
            this.tb_nomeTipoRemove.Location = new System.Drawing.Point(86, 38);
            this.tb_nomeTipoRemove.Name = "tb_nomeTipoRemove";
            this.tb_nomeTipoRemove.ReadOnly = true;
            this.tb_nomeTipoRemove.Size = new System.Drawing.Size(225, 21);
            this.tb_nomeTipoRemove.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do tipo do produto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonDataGridViewTipo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista dos tipos de produtos existentes";
            // 
            // kryptonDataGridViewTipo
            // 
            this.kryptonDataGridViewTipo.AllowUserToAddRows = false;
            this.kryptonDataGridViewTipo.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewTipo.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewTipo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewTipo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewTipo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewTipo.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewTipo.MultiSelect = false;
            this.kryptonDataGridViewTipo.Name = "kryptonDataGridViewTipo";
            this.kryptonDataGridViewTipo.RowHeadersVisible = false;
            this.kryptonDataGridViewTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewTipo.Size = new System.Drawing.Size(434, 194);
            this.kryptonDataGridViewTipo.TabIndex = 1;
            this.kryptonDataGridViewTipo.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewTipo_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.tb_nomeTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Tipo";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_addTipo);
            this.panel5.Location = new System.Drawing.Point(314, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 35);
            this.panel5.TabIndex = 40;
            // 
            // btn_addTipo
            // 
            this.btn_addTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_addTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_addTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addTipo.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.btn_addTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addTipo.Location = new System.Drawing.Point(-3, -7);
            this.btn_addTipo.Name = "btn_addTipo";
            this.btn_addTipo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_addTipo.Size = new System.Drawing.Size(120, 50);
            this.btn_addTipo.TabIndex = 10;
            this.btn_addTipo.Text = "        Adicionar";
            this.btn_addTipo.UseVisualStyleBackColor = false;
            this.btn_addTipo.Click += new System.EventHandler(this.btn_addTipo_Click);
            this.btn_addTipo.MouseEnter += new System.EventHandler(this.btn_addTipo_MouseEnter);
            this.btn_addTipo.MouseLeave += new System.EventHandler(this.btn_addTipo_MouseLeave);
            // 
            // tb_nomeTipo
            // 
            this.tb_nomeTipo.Location = new System.Drawing.Point(7, 40);
            this.tb_nomeTipo.Name = "tb_nomeTipo";
            this.tb_nomeTipo.Size = new System.Drawing.Size(298, 21);
            this.tb_nomeTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Tipo do produto:";
            // 
            // Form_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Tipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de tipos de produtos";
            this.Load += new System.EventHandler(this.Form_Tipo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_tituloTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_removeTipo;
        private System.Windows.Forms.TextBox tb_idTipoRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeTipoRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_addTipo;
        private System.Windows.Forms.TextBox tb_nomeTipo;
        private System.Windows.Forms.Label label1;
    }
}