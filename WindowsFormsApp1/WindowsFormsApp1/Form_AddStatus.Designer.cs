namespace WindowsFormsApp1
{
    partial class Form_AddStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_addCategoria = new System.Windows.Forms.Button();
            this.tb_nomeStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridViewStatus = new Krypton.Toolkit.KryptonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_removeCategoria = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_idStatusRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeStatusRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.tb_nomeStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar status";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_addCategoria);
            this.panel5.Location = new System.Drawing.Point(314, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 35);
            this.panel5.TabIndex = 40;
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
            this.btn_addCategoria.MouseEnter += new System.EventHandler(this.btn_addStatus_MouseEnter);
            this.btn_addCategoria.MouseLeave += new System.EventHandler(this.btn_addStatus_MouseLeave);
            // 
            // tb_nomeStatus
            // 
            this.tb_nomeStatus.Location = new System.Drawing.Point(7, 40);
            this.tb_nomeStatus.Name = "tb_nomeStatus";
            this.tb_nomeStatus.Size = new System.Drawing.Size(298, 21);
            this.tb_nomeStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonDataGridViewStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de status existentes";
            // 
            // kryptonDataGridViewStatus
            // 
            this.kryptonDataGridViewStatus.AllowUserToAddRows = false;
            this.kryptonDataGridViewStatus.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewStatus.AllowUserToResizeColumns = false;
            this.kryptonDataGridViewStatus.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridViewStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewStatus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridViewStatus.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridViewStatus.MultiSelect = false;
            this.kryptonDataGridViewStatus.Name = "kryptonDataGridViewStatus";
            this.kryptonDataGridViewStatus.RowHeadersVisible = false;
            this.kryptonDataGridViewStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridViewStatus.Size = new System.Drawing.Size(434, 194);
            this.kryptonDataGridViewStatus.TabIndex = 1;
            this.kryptonDataGridViewStatus.SelectionChanged += new System.EventHandler(this.kryptonDataGridViewStatus_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_removeCategoria);
            this.panel1.Location = new System.Drawing.Point(317, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 35);
            this.panel1.TabIndex = 41;
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
            this.btn_removeCategoria.Click += new System.EventHandler(this.btn_removeStatus_Click);
            this.btn_removeCategoria.MouseEnter += new System.EventHandler(this.btn_removeStatus_MouseEnter);
            this.btn_removeCategoria.MouseLeave += new System.EventHandler(this.btn_removeStatus_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.tb_idStatusRemove);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_nomeStatusRemove);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remover status";
            // 
            // tb_idStatusRemove
            // 
            this.tb_idStatusRemove.Location = new System.Drawing.Point(7, 38);
            this.tb_idStatusRemove.Name = "tb_idStatusRemove";
            this.tb_idStatusRemove.ReadOnly = true;
            this.tb_idStatusRemove.Size = new System.Drawing.Size(70, 20);
            this.tb_idStatusRemove.TabIndex = 5;
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
            // tb_nomeStatusRemove
            // 
            this.tb_nomeStatusRemove.Location = new System.Drawing.Point(86, 38);
            this.tb_nomeStatusRemove.Name = "tb_nomeStatusRemove";
            this.tb_nomeStatusRemove.ReadOnly = true;
            this.tb_nomeStatusRemove.Size = new System.Drawing.Size(225, 20);
            this.tb_nomeStatusRemove.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do status:";
            // 
            // Form_AddStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar status do usuário";
            this.Load += new System.EventHandler(this.Form_AddStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nomeStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_addCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_removeCategoria;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_idStatusRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeStatusRemove;
        private System.Windows.Forms.Label label2;
    }
}