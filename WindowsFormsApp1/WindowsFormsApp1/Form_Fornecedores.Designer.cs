namespace WindowsFormsApp1
{
    partial class Form_Fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.tb_fnpjFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_enderecoFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_emailFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_telefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_novoFornecedor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SalvarFornecedor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_gerencia.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(802, 40);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar fornecedores de produtos no sistema";
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
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel_gerencia);
            this.groupBox1.Controls.Add(this.mtb_telefoneFornecedor);
            this.groupBox1.Controls.Add(this.tb_emailFornecedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_enderecoFornecedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_fnpjFornecedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nomeFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 560);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de cadastro de fornecedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do fornecedor:";
            // 
            // tb_nomeFornecedor
            // 
            this.tb_nomeFornecedor.Location = new System.Drawing.Point(10, 41);
            this.tb_nomeFornecedor.Name = "tb_nomeFornecedor";
            this.tb_nomeFornecedor.Size = new System.Drawing.Size(239, 21);
            this.tb_nomeFornecedor.TabIndex = 1;
            // 
            // tb_fnpjFornecedor
            // 
            this.tb_fnpjFornecedor.Location = new System.Drawing.Point(10, 87);
            this.tb_fnpjFornecedor.Name = "tb_fnpjFornecedor";
            this.tb_fnpjFornecedor.Size = new System.Drawing.Size(239, 21);
            this.tb_fnpjFornecedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ:";
            // 
            // tb_enderecoFornecedor
            // 
            this.tb_enderecoFornecedor.Location = new System.Drawing.Point(255, 41);
            this.tb_enderecoFornecedor.Name = "tb_enderecoFornecedor";
            this.tb_enderecoFornecedor.Size = new System.Drawing.Size(239, 21);
            this.tb_enderecoFornecedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereço do fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // tb_emailFornecedor
            // 
            this.tb_emailFornecedor.Location = new System.Drawing.Point(500, 41);
            this.tb_emailFornecedor.Name = "tb_emailFornecedor";
            this.tb_emailFornecedor.Size = new System.Drawing.Size(269, 21);
            this.tb_emailFornecedor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-Mail:";
            // 
            // mtb_telefoneFornecedor
            // 
            this.mtb_telefoneFornecedor.Location = new System.Drawing.Point(255, 87);
            this.mtb_telefoneFornecedor.Mask = "(99) 00000-0000";
            this.mtb_telefoneFornecedor.Name = "mtb_telefoneFornecedor";
            this.mtb_telefoneFornecedor.Size = new System.Drawing.Size(189, 21);
            this.mtb_telefoneFornecedor.TabIndex = 10;
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_novoFornecedor);
            this.panel_gerencia.Location = new System.Drawing.Point(10, 126);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 17;
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
            this.btn_novoFornecedor.TabIndex = 9;
            this.btn_novoFornecedor.Text = "        Novo Fornecedor";
            this.btn_novoFornecedor.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SalvarFornecedor);
            this.panel2.Location = new System.Drawing.Point(666, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 40);
            this.panel2.TabIndex = 19;
            // 
            // btn_SalvarFornecedor
            // 
            this.btn_SalvarFornecedor.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_SalvarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_SalvarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalvarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SalvarFornecedor.Image = global::WindowsFormsApp1.Properties.Resources.diskette;
            this.btn_SalvarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarFornecedor.Location = new System.Drawing.Point(-3, -5);
            this.btn_SalvarFornecedor.Name = "btn_SalvarFornecedor";
            this.btn_SalvarFornecedor.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_SalvarFornecedor.Size = new System.Drawing.Size(108, 50);
            this.btn_SalvarFornecedor.TabIndex = 10;
            this.btn_SalvarFornecedor.Text = "        Salvar";
            this.btn_SalvarFornecedor.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonDataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(10, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 257);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedores registrados";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(753, 237);
            this.kryptonDataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(587, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 40);
            this.panel3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, -5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "        Remover Fornecedor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tb_id);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_nomeCompleto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(13, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 117);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remover fornecedor";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(15, 44);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(102, 21);
            this.tb_id.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "ID Usuário:";
            // 
            // tb_nomeCompleto
            // 
            this.tb_nomeCompleto.Location = new System.Drawing.Point(123, 44);
            this.tb_nomeCompleto.Name = "tb_nomeCompleto";
            this.tb_nomeCompleto.ReadOnly = true;
            this.tb_nomeCompleto.Size = new System.Drawing.Size(328, 21);
            this.tb_nomeCompleto.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nome completo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "CNPJ:";
            // 
            // Form_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar fornecedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_gerencia.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_enderecoFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fnpjFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_emailFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_telefoneFornecedor;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_novoFornecedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SalvarFornecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nomeCompleto;
        private System.Windows.Forms.Label label8;
    }
}