namespace WindowsFormsApp1
{
    partial class Form_Todos_Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_nivelAcesso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_statusUsuario = new System.Windows.Forms.ComboBox();
            this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_detalhesStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).BeginInit();
            this.panel_gerencia.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1060, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Todos os usuários";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 539);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do usuário";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(205, 83);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(189, 21);
            this.mtb_telefone.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.nud_nivelAcesso);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.mtb_telefone);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.tb_nomeCompleto);
            this.groupBox2.Controls.Add(this.panel_gerencia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_statusUsuario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_nomeUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 168);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // nud_nivelAcesso
            // 
            this.nud_nivelAcesso.Location = new System.Drawing.Point(582, 84);
            this.nud_nivelAcesso.Name = "nud_nivelAcesso";
            this.nud_nivelAcesso.Size = new System.Drawing.Size(120, 21);
            this.nud_nivelAcesso.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome de usuário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nível de acesso do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome completo:";
            // 
            // cb_statusUsuario
            // 
            this.cb_statusUsuario.FormattingEnabled = true;
            this.cb_statusUsuario.ItemHeight = 15;
            this.cb_statusUsuario.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_statusUsuario.Location = new System.Drawing.Point(400, 81);
            this.cb_statusUsuario.Name = "cb_statusUsuario";
            this.cb_statusUsuario.Size = new System.Drawing.Size(170, 23);
            this.cb_statusUsuario.TabIndex = 25;
            // 
            // tb_nomeCompleto
            // 
            this.tb_nomeCompleto.Location = new System.Drawing.Point(6, 37);
            this.tb_nomeCompleto.Name = "tb_nomeCompleto";
            this.tb_nomeCompleto.Size = new System.Drawing.Size(388, 21);
            this.tb_nomeCompleto.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Status do usuário:";
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Location = new System.Drawing.Point(6, 83);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(189, 21);
            this.tb_nomeUsuario.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-Mail:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(400, 37);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(388, 21);
            this.tb_email.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefone:";
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_novoUsuario);
            this.panel_gerencia.Location = new System.Drawing.Point(6, 117);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Cancelar);
            this.panel3.Location = new System.Drawing.Point(905, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 40);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Salvar);
            this.panel2.Location = new System.Drawing.Point(593, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 40);
            this.panel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(749, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 40);
            this.panel4.TabIndex = 20;
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
            this.button1.Size = new System.Drawing.Size(153, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "        Excluir usuário";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btn_Salvar.Size = new System.Drawing.Size(153, 50);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "        Salvar alterações";
            this.btn_Salvar.UseVisualStyleBackColor = false;
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
            this.groupBox3.Controls.Add(this.kryptonDataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(8, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1021, 338);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabela de usuário";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1015, 318);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_detalhesStatus);
            this.groupBox4.Location = new System.Drawing.Point(794, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 82);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalhes do status";
            // 
            // lb_detalhesStatus
            // 
            this.lb_detalhesStatus.Location = new System.Drawing.Point(7, 20);
            this.lb_detalhesStatus.Name = "lb_detalhesStatus";
            this.lb_detalhesStatus.Size = new System.Drawing.Size(136, 52);
            this.lb_detalhesStatus.TabIndex = 0;
            // 
            // Form_Todos_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Todos_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de usuários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).EndInit();
            this.panel_gerencia.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_nivelAcesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_statusUsuario;
        private System.Windows.Forms.TextBox tb_nomeCompleto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nomeUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_novoUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_detalhesStatus;
    }
}