﻿namespace WindowsFormsApp1
{
    partial class FormAdicionarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarFornecedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_verTodosFornecedores = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SalvarFornecedor = new System.Windows.Forms.Button();
            this.mtb_telefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.tb_emailFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_enderecoFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cnpjFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.mtb_telefoneFornecedor);
            this.groupBox1.Controls.Add(this.tb_emailFornecedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_enderecoFornecedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_cnpjFornecedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nomeFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de cadastro de fornecedores";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_verTodosFornecedores);
            this.panel4.Location = new System.Drawing.Point(10, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 40);
            this.panel4.TabIndex = 20;
            // 
            // btn_verTodosFornecedores
            // 
            this.btn_verTodosFornecedores.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_verTodosFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_verTodosFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verTodosFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verTodosFornecedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_verTodosFornecedores.Image = global::WindowsFormsApp1.Properties.Resources.graph;
            this.btn_verTodosFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verTodosFornecedores.Location = new System.Drawing.Point(-4, -5);
            this.btn_verTodosFornecedores.Name = "btn_verTodosFornecedores";
            this.btn_verTodosFornecedores.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_verTodosFornecedores.Size = new System.Drawing.Size(197, 50);
            this.btn_verTodosFornecedores.TabIndex = 7;
            this.btn_verTodosFornecedores.Text = "        Ver todos os fornecedores";
            this.btn_verTodosFornecedores.UseVisualStyleBackColor = false;
            this.btn_verTodosFornecedores.Click += new System.EventHandler(this.btn_verTodosFornecedores_Click);
            this.btn_verTodosFornecedores.MouseEnter += new System.EventHandler(this.btn_verTodosFornecedores_MouseEnter);
            this.btn_verTodosFornecedores.MouseLeave += new System.EventHandler(this.btn_verTodosFornecedores_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Cancelar);
            this.panel3.Location = new System.Drawing.Point(466, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 40);
            this.panel3.TabIndex = 21;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Image = global::WindowsFormsApp1.Properties.Resources.cross;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(-5, -5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 50);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "        Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            this.btn_Cancelar.MouseEnter += new System.EventHandler(this.btn_Cancelar_MouseEnter);
            this.btn_Cancelar.MouseLeave += new System.EventHandler(this.btn_Cancelar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SalvarFornecedor);
            this.panel2.Location = new System.Drawing.Point(329, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 40);
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
            this.btn_SalvarFornecedor.Location = new System.Drawing.Point(-4, -5);
            this.btn_SalvarFornecedor.Name = "btn_SalvarFornecedor";
            this.btn_SalvarFornecedor.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_SalvarFornecedor.Size = new System.Drawing.Size(137, 50);
            this.btn_SalvarFornecedor.TabIndex = 7;
            this.btn_SalvarFornecedor.Text = "        Salvar";
            this.btn_SalvarFornecedor.UseVisualStyleBackColor = false;
            this.btn_SalvarFornecedor.Click += new System.EventHandler(this.btn_SalvarFornecedor_Click);
            this.btn_SalvarFornecedor.MouseEnter += new System.EventHandler(this.btn_SalvarFornecedor_MouseEnter);
            this.btn_SalvarFornecedor.MouseLeave += new System.EventHandler(this.btn_SalvarFornecedor_MouseLeave);
            // 
            // mtb_telefoneFornecedor
            // 
            this.mtb_telefoneFornecedor.Location = new System.Drawing.Point(304, 40);
            this.mtb_telefoneFornecedor.Mask = "(99) 00000-0000";
            this.mtb_telefoneFornecedor.Name = "mtb_telefoneFornecedor";
            this.mtb_telefoneFornecedor.Size = new System.Drawing.Size(189, 21);
            this.mtb_telefoneFornecedor.TabIndex = 4;
            // 
            // tb_emailFornecedor
            // 
            this.tb_emailFornecedor.Location = new System.Drawing.Point(304, 84);
            this.tb_emailFornecedor.Name = "tb_emailFornecedor";
            this.tb_emailFornecedor.Size = new System.Drawing.Size(269, 21);
            this.tb_emailFornecedor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // tb_enderecoFornecedor
            // 
            this.tb_enderecoFornecedor.Location = new System.Drawing.Point(10, 134);
            this.tb_enderecoFornecedor.Name = "tb_enderecoFornecedor";
            this.tb_enderecoFornecedor.Size = new System.Drawing.Size(278, 21);
            this.tb_enderecoFornecedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereço do fornecedor:";
            // 
            // tb_cnpjFornecedor
            // 
            this.tb_cnpjFornecedor.Location = new System.Drawing.Point(10, 84);
            this.tb_cnpjFornecedor.MaxLength = 15;
            this.tb_cnpjFornecedor.Name = "tb_cnpjFornecedor";
            this.tb_cnpjFornecedor.Size = new System.Drawing.Size(288, 21);
            this.tb_cnpjFornecedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ:";
            // 
            // tb_nomeFornecedor
            // 
            this.tb_nomeFornecedor.Location = new System.Drawing.Point(9, 40);
            this.tb_nomeFornecedor.Name = "tb_nomeFornecedor";
            this.tb_nomeFornecedor.Size = new System.Drawing.Size(289, 21);
            this.tb_nomeFornecedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do fornecedor:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(342, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 202);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 40);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(137, 9);
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
            // Form_AddFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar fornecedor no sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SalvarFornecedor;
        private System.Windows.Forms.MaskedTextBox mtb_telefoneFornecedor;
        private System.Windows.Forms.TextBox tb_emailFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_enderecoFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cnpjFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_verTodosFornecedores;
    }
}