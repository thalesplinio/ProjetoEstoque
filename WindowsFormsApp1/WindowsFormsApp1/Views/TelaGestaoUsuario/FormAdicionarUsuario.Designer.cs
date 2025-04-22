namespace WindowsFormsApp1
{
    partial class FormAdicionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_addStatus = new System.Windows.Forms.Button();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.nud_nivelAcesso = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_statusUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_repeteSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_gerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicioanar usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.mtb_telefone);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel_gerencia);
            this.groupBox2.Controls.Add(this.nud_nivelAcesso);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_statusUsuario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_repeteSenha);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_senha);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_nomeUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_nomeCompleto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(10, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do usuário";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_info);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Help;
            this.panel5.Location = new System.Drawing.Point(555, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 27);
            this.panel5.TabIndex = 20;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.Control;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_info.Image = global::WindowsFormsApp1.Properties.Resources.info;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info.Location = new System.Drawing.Point(-8, -8);
            this.btn_info.Name = "btn_info";
            this.btn_info.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_info.Size = new System.Drawing.Size(49, 40);
            this.btn_info.TabIndex = 5;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            this.btn_info.MouseEnter += new System.EventHandler(this.btn_info_MouseEnter);
            this.btn_info.MouseLeave += new System.EventHandler(this.btn_info_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_addStatus);
            this.panel4.Location = new System.Drawing.Point(605, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 35);
            this.panel4.TabIndex = 18;
            // 
            // btn_addStatus
            // 
            this.btn_addStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_addStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_addStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addStatus.Image = global::WindowsFormsApp1.Properties.Resources.clipboard;
            this.btn_addStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addStatus.Location = new System.Drawing.Point(-3, -7);
            this.btn_addStatus.Name = "btn_addStatus";
            this.btn_addStatus.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_addStatus.Size = new System.Drawing.Size(120, 50);
            this.btn_addStatus.TabIndex = 10;
            this.btn_addStatus.Text = "        Criar status";
            this.btn_addStatus.UseVisualStyleBackColor = false;
            this.btn_addStatus.Click += new System.EventHandler(this.btn_addStatus_Click);
            this.btn_addStatus.MouseEnter += new System.EventHandler(this.btn_addStatus_MouseEnter);
            this.btn_addStatus.MouseLeave += new System.EventHandler(this.btn_addStatus_MouseLeave);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(7, 184);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(189, 21);
            this.mtb_telefone.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Cancelar);
            this.panel3.Location = new System.Drawing.Point(645, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 40);
            this.panel3.TabIndex = 18;
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
            this.panel2.Controls.Add(this.btn_Salvar);
            this.panel2.Location = new System.Drawing.Point(531, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 40);
            this.panel2.TabIndex = 17;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salvar.Image = global::WindowsFormsApp1.Properties.Resources.diskette;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(-3, -5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Salvar.Size = new System.Drawing.Size(108, 50);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "        Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            this.btn_Salvar.MouseEnter += new System.EventHandler(this.btn_Salvar_MouseEnter);
            this.btn_Salvar.MouseLeave += new System.EventHandler(this.btn_Salvar_MouseLeave);
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_novoUsuario);
            this.panel_gerencia.Location = new System.Drawing.Point(7, 284);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 16;
            // 
            // btn_novoUsuario
            // 
            this.btn_novoUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_novoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_novoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_novoUsuario.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_novoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novoUsuario.Location = new System.Drawing.Point(-5, -5);
            this.btn_novoUsuario.Name = "btn_novoUsuario";
            this.btn_novoUsuario.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_novoUsuario.Size = new System.Drawing.Size(159, 50);
            this.btn_novoUsuario.TabIndex = 9;
            this.btn_novoUsuario.Text = "        Novo Usuário";
            this.btn_novoUsuario.UseVisualStyleBackColor = false;
            this.btn_novoUsuario.Click += new System.EventHandler(this.btn_novoUsuario_Click);
            this.btn_novoUsuario.MouseEnter += new System.EventHandler(this.btn_novoUsuario_MouseEnter);
            this.btn_novoUsuario.MouseLeave += new System.EventHandler(this.btn_novoUsuario_MouseLeave);
            // 
            // nud_nivelAcesso
            // 
            this.nud_nivelAcesso.Location = new System.Drawing.Point(429, 85);
            this.nud_nivelAcesso.Name = "nud_nivelAcesso";
            this.nud_nivelAcesso.Size = new System.Drawing.Size(120, 21);
            this.nud_nivelAcesso.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nível de acesso do usuário:";
            // 
            // cb_statusUsuario
            // 
            this.cb_statusUsuario.FormattingEnabled = true;
            this.cb_statusUsuario.ItemHeight = 15;
            this.cb_statusUsuario.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_statusUsuario.Location = new System.Drawing.Point(429, 37);
            this.cb_statusUsuario.Name = "cb_statusUsuario";
            this.cb_statusUsuario.Size = new System.Drawing.Size(170, 23);
            this.cb_statusUsuario.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Status do usuário:";
            // 
            // tb_repeteSenha
            // 
            this.tb_repeteSenha.Location = new System.Drawing.Point(206, 235);
            this.tb_repeteSenha.Name = "tb_repeteSenha";
            this.tb_repeteSenha.PasswordChar = '*';
            this.tb_repeteSenha.Size = new System.Drawing.Size(189, 21);
            this.tb_repeteSenha.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Repetir senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(7, 235);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(189, 21);
            this.tb_senha.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(7, 139);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(388, 21);
            this.tb_email.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail:";
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Location = new System.Drawing.Point(7, 91);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(189, 21);
            this.tb_nomeUsuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome de usuário:";
            // 
            // tb_nomeCompleto
            // 
            this.tb_nomeCompleto.Location = new System.Drawing.Point(7, 43);
            this.tb_nomeCompleto.Name = "tb_nomeCompleto";
            this.tb_nomeCompleto.Size = new System.Drawing.Size(388, 21);
            this.tb_nomeCompleto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome completo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox2.Location = new System.Drawing.Point(453, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 196);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preencha o formulário abaixo com todas as informações necessárias.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicioanar usuário";
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
            // Form_AddUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar usuário do sistema";
            this.Load += new System.EventHandler(this.Form_AddUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_gerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nomeCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_nivelAcesso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_statusUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_repeteSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_novoUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_addStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_info;
    }
}