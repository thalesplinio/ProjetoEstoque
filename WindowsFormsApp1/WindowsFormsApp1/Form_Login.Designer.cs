namespace WindowsFormsApp1
{
    partial class Form_Login
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
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_subTitleLogin = new System.Windows.Forms.Label();
            this.ktb_Login = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ktb_senha = new Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(97)))));
            this.lb_Login.Location = new System.Drawing.Point(15, 9);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(603, 58);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Login";
            this.lb_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_subTitleLogin
            // 
            this.lb_subTitleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subTitleLogin.Location = new System.Drawing.Point(14, 67);
            this.lb_subTitleLogin.Name = "lb_subTitleLogin";
            this.lb_subTitleLogin.Size = new System.Drawing.Size(604, 20);
            this.lb_subTitleLogin.TabIndex = 1;
            this.lb_subTitleLogin.Text = "Por favor, preencha suas informações para porder acessar o sistema. ";
            this.lb_subTitleLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ktb_Login
            // 
            this.ktb_Login.Location = new System.Drawing.Point(218, 117);
            this.ktb_Login.Name = "ktb_Login";
            this.ktb_Login.Size = new System.Drawing.Size(194, 28);
            this.ktb_Login.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktb_Login.StateCommon.Border.Rounding = 8F;
            this.ktb_Login.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktb_Login.TabIndex = 1;
            this.ktb_Login.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome de usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // ktb_senha
            // 
            this.ktb_senha.Location = new System.Drawing.Point(218, 168);
            this.ktb_senha.Name = "ktb_senha";
            this.ktb_senha.PasswordChar = '*';
            this.ktb_senha.Size = new System.Drawing.Size(194, 28);
            this.ktb_senha.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktb_senha.StateCommon.Border.Rounding = 8F;
            this.ktb_senha.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktb_senha.TabIndex = 2;
            this.ktb_senha.Text = "123";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(203, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 35);
            this.panel1.TabIndex = 7;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrar.Image = global::WindowsFormsApp1.Properties.Resources.log_in;
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrar.Location = new System.Drawing.Point(-2, -4);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_entrar.Size = new System.Drawing.Size(108, 43);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "      Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            this.btn_entrar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btn_entrar.MouseLeave += new System.EventHandler(this.btn_entrar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(315, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 35);
            this.panel2.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Image = global::WindowsFormsApp1.Properties.Resources.cross;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(-2, -4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_cancel.Size = new System.Drawing.Size(108, 43);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "      Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_cancel_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_cancel_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_info);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Help;
            this.panel3.Location = new System.Drawing.Point(582, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 35);
            this.panel3.TabIndex = 9;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.Control;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_info.Image = global::WindowsFormsApp1.Properties.Resources.info;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info.Location = new System.Drawing.Point(-5, -4);
            this.btn_info.Name = "btn_info";
            this.btn_info.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_info.Size = new System.Drawing.Size(49, 43);
            this.btn_info.TabIndex = 5;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.MouseEnter += new System.EventHandler(this.btn_info_MouseEnter);
            this.btn_info.MouseLeave += new System.EventHandler(this.btn_info_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo_opac;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 191);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ktb_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ktb_Login);
            this.Controls.Add(this.lb_subTitleLogin);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_subTitleLogin;
        private Krypton.Toolkit.KryptonTextBox ktb_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox ktb_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}