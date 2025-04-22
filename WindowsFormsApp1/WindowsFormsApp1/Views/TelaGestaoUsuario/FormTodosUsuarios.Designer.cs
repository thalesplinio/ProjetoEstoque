namespace WindowsFormsApp1
{
    partial class FormTodosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTodosUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_dataAlteracaoCadastro = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_dataBanco = new System.Windows.Forms.Label();
            this.tb_tituloData = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_repetirSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_ExluirUsuario = new System.Windows.Forms.Button();
            this.nud_nivelAcesso = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_statusUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_gerencia.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1160, 40);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 618);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do usuário";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kryptonDataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(8, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1121, 367);
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 17);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1115, 347);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.SelectionChanged += new System.EventHandler(this.kryptonDataGridView1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lb_dataAlteracaoCadastro);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_dataBanco);
            this.groupBox2.Controls.Add(this.tb_tituloData);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.label2);
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
            this.groupBox2.Size = new System.Drawing.Size(1119, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_info);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Help;
            this.panel6.Location = new System.Drawing.Point(576, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 27);
            this.panel6.TabIndex = 40;
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
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(239, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 13);
            this.label11.TabIndex = 38;
            // 
            // lb_dataAlteracaoCadastro
            // 
            this.lb_dataAlteracaoCadastro.AutoSize = true;
            this.lb_dataAlteracaoCadastro.Location = new System.Drawing.Point(421, 116);
            this.lb_dataAlteracaoCadastro.Name = "lb_dataAlteracaoCadastro";
            this.lb_dataAlteracaoCadastro.Size = new System.Drawing.Size(0, 15);
            this.lb_dataAlteracaoCadastro.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Data de alteração do cadastro:";
            // 
            // tb_dataBanco
            // 
            this.tb_dataBanco.AutoSize = true;
            this.tb_dataBanco.Location = new System.Drawing.Point(111, 116);
            this.tb_dataBanco.Name = "tb_dataBanco";
            this.tb_dataBanco.Size = new System.Drawing.Size(0, 15);
            this.tb_dataBanco.TabIndex = 35;
            // 
            // tb_tituloData
            // 
            this.tb_tituloData.AutoSize = true;
            this.tb_tituloData.Location = new System.Drawing.Point(8, 116);
            this.tb_tituloData.Name = "tb_tituloData";
            this.tb_tituloData.Size = new System.Drawing.Size(103, 15);
            this.tb_tituloData.TabIndex = 34;
            this.tb_tituloData.Text = "Data de cadastro:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_repetirSenha);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tb_senha);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(822, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 128);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Redefinir senha";
            // 
            // tb_repetirSenha
            // 
            this.tb_repetirSenha.Location = new System.Drawing.Point(6, 87);
            this.tb_repetirSenha.Name = "tb_repetirSenha";
            this.tb_repetirSenha.PasswordChar = '*';
            this.tb_repetirSenha.Size = new System.Drawing.Size(189, 21);
            this.tb_repetirSenha.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Repertir senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(6, 39);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(189, 21);
            this.tb_senha.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Senha:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(9, 37);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(102, 21);
            this.tb_id.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Usuário:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_ExluirUsuario);
            this.panel4.Location = new System.Drawing.Point(847, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 40);
            this.panel4.TabIndex = 20;
            // 
            // btn_ExluirUsuario
            // 
            this.btn_ExluirUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_ExluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_ExluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExluirUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ExluirUsuario.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btn_ExluirUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExluirUsuario.Location = new System.Drawing.Point(-3, -5);
            this.btn_ExluirUsuario.Name = "btn_ExluirUsuario";
            this.btn_ExluirUsuario.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_ExluirUsuario.Size = new System.Drawing.Size(153, 50);
            this.btn_ExluirUsuario.TabIndex = 10;
            this.btn_ExluirUsuario.Text = "        Excluir usuário";
            this.btn_ExluirUsuario.UseVisualStyleBackColor = false;
            this.btn_ExluirUsuario.Click += new System.EventHandler(this.button1_Click);
            this.btn_ExluirUsuario.MouseEnter += new System.EventHandler(this.btn_ExluirUsuario_MouseEnter);
            this.btn_ExluirUsuario.MouseLeave += new System.EventHandler(this.btn_ExluirUsuario_MouseLeave);
            // 
            // nud_nivelAcesso
            // 
            this.nud_nivelAcesso.Location = new System.Drawing.Point(451, 81);
            this.nud_nivelAcesso.Name = "nud_nivelAcesso";
            this.nud_nivelAcesso.Size = new System.Drawing.Size(120, 21);
            this.nud_nivelAcesso.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Cancelar);
            this.panel3.Location = new System.Drawing.Point(1003, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 40);
            this.panel3.TabIndex = 20;
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
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(9, 80);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(145, 21);
            this.mtb_telefone.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Salvar);
            this.panel2.Location = new System.Drawing.Point(691, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 40);
            this.panel2.TabIndex = 19;
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
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            this.btn_Salvar.MouseEnter += new System.EventHandler(this.btn_Salvar_MouseEnter);
            this.btn_Salvar.MouseLeave += new System.EventHandler(this.btn_Salvar_MouseLeave);
            // 
            // tb_nomeCompleto
            // 
            this.tb_nomeCompleto.Location = new System.Drawing.Point(117, 37);
            this.tb_nomeCompleto.Name = "tb_nomeCompleto";
            this.tb_nomeCompleto.Size = new System.Drawing.Size(328, 21);
            this.tb_nomeCompleto.TabIndex = 1;
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_novoUsuario);
            this.panel_gerencia.Location = new System.Drawing.Point(6, 170);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 17;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nível de acesso do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 17);
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
            this.cb_statusUsuario.Location = new System.Drawing.Point(646, 35);
            this.cb_statusUsuario.Name = "cb_statusUsuario";
            this.cb_statusUsuario.Size = new System.Drawing.Size(170, 23);
            this.cb_statusUsuario.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Status do usuário:";
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Location = new System.Drawing.Point(451, 37);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(189, 21);
            this.tb_nomeUsuario.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome de usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefone:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(160, 81);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(285, 21);
            this.tb_email.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-Mail:";
            // 
            // Form_Todos_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Todos_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de usuários";
            this.Load += new System.EventHandler(this.Form_Todos_Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivelAcesso)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_gerencia.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_ExluirUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_repetirSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tb_dataBanco;
        private System.Windows.Forms.Label tb_tituloData;
        private System.Windows.Forms.Label lb_dataAlteracaoCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_info;
    }
}