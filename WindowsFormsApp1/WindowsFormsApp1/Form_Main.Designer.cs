namespace WindowsFormsApp1
{
    partial class Form_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_gerencia = new System.Windows.Forms.Panel();
            this.btn_gerenciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_separador2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_UserLogado = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_listar = new System.Windows.Forms.Panel();
            this.btn_listar = new System.Windows.Forms.Button();
            this.panel_cadastrar = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.panel_retirar = new System.Windows.Forms.Panel();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_owner = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_separador = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMateriaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarMateriaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tarocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosOsRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel_gerencia.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_listar.SuspendLayout();
            this.panel_cadastrar.SuspendLayout();
            this.panel_retirar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.panel_gerencia);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Controls.Add(this.panel_listar);
            this.panel1.Controls.Add(this.panel_cadastrar);
            this.panel1.Controls.Add(this.panel_retirar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel_gerencia
            // 
            this.panel_gerencia.Controls.Add(this.btn_gerenciar);
            this.panel_gerencia.Location = new System.Drawing.Point(549, 0);
            this.panel_gerencia.Name = "panel_gerencia";
            this.panel_gerencia.Size = new System.Drawing.Size(151, 40);
            this.panel_gerencia.TabIndex = 7;
            // 
            // btn_gerenciar
            // 
            this.btn_gerenciar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_gerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_gerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerenciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gerenciar.Image = global::WindowsFormsApp1.Properties.Resources.configuration;
            this.btn_gerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gerenciar.Location = new System.Drawing.Point(-4, -5);
            this.btn_gerenciar.Name = "btn_gerenciar";
            this.btn_gerenciar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_gerenciar.Size = new System.Drawing.Size(159, 50);
            this.btn_gerenciar.TabIndex = 3;
            this.btn_gerenciar.Text = "        Gerenciar estoque";
            this.btn_gerenciar.UseVisualStyleBackColor = false;
            this.btn_gerenciar.MouseEnter += new System.EventHandler(this.btn_gerenciar_MouseEnter);
            this.btn_gerenciar.MouseLeave += new System.EventHandler(this.btn_gerenciar_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_separador2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lb_UserLogado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1127, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 40);
            this.panel3.TabIndex = 8;
            // 
            // lb_separador2
            // 
            this.lb_separador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_separador2.Location = new System.Drawing.Point(0, 7);
            this.lb_separador2.Name = "lb_separador2";
            this.lb_separador2.Size = new System.Drawing.Size(1, 25);
            this.lb_separador2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.@__user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lb_UserLogado
            // 
            this.lb_UserLogado.AutoSize = true;
            this.lb_UserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserLogado.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_UserLogado.Location = new System.Drawing.Point(43, 13);
            this.lb_UserLogado.Name = "lb_UserLogado";
            this.lb_UserLogado.Size = new System.Drawing.Size(16, 15);
            this.lb_UserLogado.TabIndex = 3;
            this.lb_UserLogado.Text = "...";
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(100, 40);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel_listar
            // 
            this.panel_listar.Controls.Add(this.btn_listar);
            this.panel_listar.Location = new System.Drawing.Point(403, 0);
            this.panel_listar.Name = "panel_listar";
            this.panel_listar.Size = new System.Drawing.Size(151, 40);
            this.panel_listar.TabIndex = 6;
            // 
            // btn_listar
            // 
            this.btn_listar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_listar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_listar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_listar.Image = global::WindowsFormsApp1.Properties.Resources.completed_task;
            this.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listar.Location = new System.Drawing.Point(-4, -5);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_listar.Size = new System.Drawing.Size(159, 50);
            this.btn_listar.TabIndex = 3;
            this.btn_listar.Text = "     Listar produtos";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            this.btn_listar.MouseEnter += new System.EventHandler(this.btn_listar_MouseEnter);
            this.btn_listar.MouseLeave += new System.EventHandler(this.btn_listar_MouseLeave);
            // 
            // panel_cadastrar
            // 
            this.panel_cadastrar.Controls.Add(this.btn_cadastrar);
            this.panel_cadastrar.Location = new System.Drawing.Point(101, 0);
            this.panel_cadastrar.Name = "panel_cadastrar";
            this.panel_cadastrar.Size = new System.Drawing.Size(151, 40);
            this.panel_cadastrar.TabIndex = 4;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadastrar.Image = global::WindowsFormsApp1.Properties.Resources.open_box;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(-4, -5);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_cadastrar.Size = new System.Drawing.Size(159, 50);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "     Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            this.btn_cadastrar.MouseEnter += new System.EventHandler(this.btn_cadastrar_MouseEnter);
            this.btn_cadastrar.MouseLeave += new System.EventHandler(this.btn_cadastrar_MouseLeave);
            // 
            // panel_retirar
            // 
            this.panel_retirar.Controls.Add(this.btn_retirar);
            this.panel_retirar.Location = new System.Drawing.Point(252, 0);
            this.panel_retirar.Name = "panel_retirar";
            this.panel_retirar.Size = new System.Drawing.Size(151, 40);
            this.panel_retirar.TabIndex = 5;
            // 
            // btn_retirar
            // 
            this.btn_retirar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btn_retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_retirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_retirar.Image = global::WindowsFormsApp1.Properties.Resources.remove;
            this.btn_retirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retirar.Location = new System.Drawing.Point(-4, -5);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_retirar.Size = new System.Drawing.Size(159, 50);
            this.btn_retirar.TabIndex = 3;
            this.btn_retirar.Text = "     Retirar produto";
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.MouseEnter += new System.EventHandler(this.btn_retirar_MouseEnter);
            this.btn_retirar.MouseLeave += new System.EventHandler(this.btn_retirar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_owner);
            this.panel2.Controls.Add(this.lb_date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_separador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 24);
            this.panel2.TabIndex = 1;
            // 
            // lb_owner
            // 
            this.lb_owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_owner.Location = new System.Drawing.Point(847, 4);
            this.lb_owner.Name = "lb_owner";
            this.lb_owner.Size = new System.Drawing.Size(414, 19);
            this.lb_owner.TabIndex = 6;
            this.lb_owner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_date
            // 
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(428, 4);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(406, 19);
            this.lb_date.TabIndex = 5;
            this.lb_date.Text = "...";
            this.lb_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(840, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 22);
            this.label1.TabIndex = 4;
            // 
            // lb_separador
            // 
            this.lb_separador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_separador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_separador.Location = new System.Drawing.Point(420, 1);
            this.lb_separador.Name = "lb_separador";
            this.lb_separador.Size = new System.Drawing.Size(1, 22);
            this.lb_separador.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 23);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirMaterialToolStripMenuItem,
            this.listarMateriaisToolStripMenuItem,
            this.retirarMateriaisToolStripMenuItem,
            this.toolStripSeparator1,
            this.tarocarUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // inserirMaterialToolStripMenuItem
            // 
            this.inserirMaterialToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.open_box;
            this.inserirMaterialToolStripMenuItem.Name = "inserirMaterialToolStripMenuItem";
            this.inserirMaterialToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inserirMaterialToolStripMenuItem.Text = "Inserir material";
            // 
            // listarMateriaisToolStripMenuItem
            // 
            this.listarMateriaisToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.completed_task;
            this.listarMateriaisToolStripMenuItem.Name = "listarMateriaisToolStripMenuItem";
            this.listarMateriaisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listarMateriaisToolStripMenuItem.Text = "Listar materiais";
            // 
            // retirarMateriaisToolStripMenuItem
            // 
            this.retirarMateriaisToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.remove;
            this.retirarMateriaisToolStripMenuItem.Name = "retirarMateriaisToolStripMenuItem";
            this.retirarMateriaisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.retirarMateriaisToolStripMenuItem.Text = "Retirar materiais";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // tarocarUsuárioToolStripMenuItem
            // 
            this.tarocarUsuárioToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.tarocarUsuárioToolStripMenuItem.Name = "tarocarUsuárioToolStripMenuItem";
            this.tarocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tarocarUsuárioToolStripMenuItem.Text = "Trocar usuário";
            this.tarocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.tarocarUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._switch;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosOsRegistrosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // listarTodosOsRegistrosToolStripMenuItem
            // 
            this.listarTodosOsRegistrosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.notes;
            this.listarTodosOsRegistrosToolStripMenuItem.Name = "listarTodosOsRegistrosToolStripMenuItem";
            this.listarTodosOsRegistrosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listarTodosOsRegistrosToolStripMenuItem.Text = "Listar todos os registros";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarUsuáriosToolStripMenuItem,
            this.verUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // adicionarUsuáriosToolStripMenuItem
            // 
            this.adicionarUsuáriosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.add_user;
            this.adicionarUsuáriosToolStripMenuItem.Name = "adicionarUsuáriosToolStripMenuItem";
            this.adicionarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.adicionarUsuáriosToolStripMenuItem.Text = "Adicionar usuários";
            this.adicionarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.adicionarUsuáriosToolStripMenuItem_Click);
            // 
            // verUsuáriosToolStripMenuItem
            // 
            this.verUsuáriosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.group;
            this.verUsuáriosToolStripMenuItem.Name = "verUsuáriosToolStripMenuItem";
            this.verUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verUsuáriosToolStripMenuItem.Text = "Ver usuários";
            this.verUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.verUsuáriosToolStripMenuItem_Click_1);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFornecedorToolStripMenuItem,
            this.verFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // adicionarFornecedorToolStripMenuItem
            // 
            this.adicionarFornecedorToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.delivery_truck;
            this.adicionarFornecedorToolStripMenuItem.Name = "adicionarFornecedorToolStripMenuItem";
            this.adicionarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.adicionarFornecedorToolStripMenuItem.Text = "Adicionar fornecedor";
            this.adicionarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.adicionarFornecedorToolStripMenuItem_Click);
            // 
            // verFornecedoresToolStripMenuItem
            // 
            this.verFornecedoresToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.box_truck;
            this.verFornecedoresToolStripMenuItem.Name = "verFornecedoresToolStripMenuItem";
            this.verFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verFornecedoresToolStripMenuItem.Text = "Ver fornecedores";
            this.verFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.verFornecedoresToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem,
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem,
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem,
            this.relatórioDeUsuáriosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatóriosDeInserçãoDeProdutosToolStripMenuItem
            // 
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.graph;
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem.Name = "relatóriosDeInserçãoDeProdutosToolStripMenuItem";
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem.Text = "Relatórios de inserção de produtos";
            this.relatóriosDeInserçãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeInserçãoDeProdutosToolStripMenuItem_Click);
            // 
            // relatórioDeRetiradaDeProdutosToolStripMenuItem
            // 
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.graph;
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem.Name = "relatórioDeRetiradaDeProdutosToolStripMenuItem";
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem.Text = "Relatório de retirada de produtos";
            this.relatórioDeRetiradaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeRetiradaDeProdutosToolStripMenuItem_Click);
            // 
            // relatórioDeTodosOsMateriaisInseridosToolStripMenuItem
            // 
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.graph;
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem.Name = "relatórioDeTodosOsMateriaisInseridosToolStripMenuItem";
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem.Text = "Relatório de todos os materiais inseridos";
            this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeTodosOsMateriaisInseridosToolStripMenuItem_Click);
            // 
            // relatórioDeUsuáriosToolStripMenuItem
            // 
            this.relatórioDeUsuáriosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.graph;
            this.relatórioDeUsuáriosToolStripMenuItem.Name = "relatórioDeUsuáriosToolStripMenuItem";
            this.relatórioDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.relatórioDeUsuáriosToolStripMenuItem.Text = "Relatório de usuários";
            this.relatórioDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeUsuáriosToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesGeraisToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // configuraçõesGeraisToolStripMenuItem
            // 
            this.configuraçõesGeraisToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.gears;
            this.configuraçõesGeraisToolStripMenuItem.Name = "configuraçõesGeraisToolStripMenuItem";
            this.configuraçõesGeraisToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.configuraçõesGeraisToolStripMenuItem.Text = "Configurações gerais";
            this.configuraçõesGeraisToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesGeraisToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel_gerencia.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_listar.ResumeLayout(false);
            this.panel_cadastrar.ResumeLayout(false);
            this.panel_retirar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_cadastrar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Panel panel_retirar;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Panel panel_listar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Panel panel_gerencia;
        private System.Windows.Forms.Button btn_gerenciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_separador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_owner;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMateriaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarMateriaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosOsRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeInserçãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeRetiradaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeTodosOsMateriaisInseridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesGeraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        public System.Windows.Forms.Label lb_UserLogado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_separador2;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFornecedoresToolStripMenuItem;
    }
}

