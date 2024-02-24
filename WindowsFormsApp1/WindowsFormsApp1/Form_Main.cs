using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        DataTable dataTable = null;

        public Form_Main()
        {
            InitializeComponent();
            Form_Login form_Login = new Form_Login(this);
            form_Login.ShowDialog();

            DateTime date = DateTime.Now;
            lb_date.Text = $"{date:D} {date:T}";

            lb_owner.Text = Globais.versao;
        }

        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            //public static Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
            public static Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D

        }
        #endregion

        #region Buttons Hover Color
        private void btn_cadastrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_cadastrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_retirar_MouseEnter(object sender, EventArgs e)
        {
            btn_retirar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_retirar_MouseLeave(object sender, EventArgs e)
        {
            btn_retirar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_listar_MouseEnter(object sender, EventArgs e)
        {
            btn_listar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_listar_MouseLeave(object sender, EventArgs e)
        {
            btn_listar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_gerenciar_MouseEnter(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_gerenciar_MouseLeave(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void tarocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login(this);
            form_Login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuario deslogado
            lb_UserLogado.Text = "...";
            Globais.nivel = 0;
            Globais.logado = false;
            this.Close();

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show(
                "Deseja realmente fechar a aplicação?",
                "Fechar?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Restringindo acessos aos Relatórios de nivel -2
        private void AbreFormularioBaseNivel(int nivel, Form formulario)
        {
            // usuário logado
            if (Globais.logado)
            {
                // Só acessa nivel >= 2 Master
                if (Globais.nivel >= nivel)
                {
                    // Procedimentos
                    formulario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void relatóriosDeInserçãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuário logado Nivel 2
        }

        private void relatórioDeRetiradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuário logado Nivel 2
        }

        private void relatórioDeTodosOsMateriaisInseridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuário logado Nivel 2
        }

        private void relatórioDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuário logado Nivel 2
        }
        #endregion

        private void adicionarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddUsuario form_AddUsuario = new Form_AddUsuario();
            AbreFormularioBaseNivel(2, form_AddUsuario);
        }

        private void verUsuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Todos_Usuarios form_Todos_Usuarios = new Form_Todos_Usuarios();
            AbreFormularioBaseNivel(2, form_Todos_Usuarios);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Cadastro form_Cadastro = new Form_Cadastro(this);
            AbreFormularioBaseNivel(1, form_Cadastro);
        }

        private void configuraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Config form_Config = new Form_Config();
            AbreFormularioBaseNivel(1, form_Config);
        }

        private void adicionarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddFornecedor form_AddFornecedor = new Form_AddFornecedor();
            AbreFormularioBaseNivel(1, form_AddFornecedor);
        }

        private void verFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fornecedores form_Fornecedores = new Form_Fornecedores();
            AbreFormularioBaseNivel(1, form_Fornecedores);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
