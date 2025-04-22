using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models.Usuario.DAO;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        #region Set Colors Butons
        public Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
        public Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D

        public Color corAzulPadraoForte = Color.FromArgb(16, 31, 49); // 
        public Color corAzulPadraoClaro = Color.FromArgb(19, 37, 59); // 

        public Color corControl = Color.FromArgb(240, 240, 240);
        public Color corControlLight = Color.FromArgb(227, 227, 227);

        public Color corInterface = Color.FromArgb(1, 46, 63);
        #endregion

        #region Buttons color Hover
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_entrar.BackColor = corAzulPadrao;
        }

        private void btn_entrar_MouseLeave(object sender, EventArgs e)
        {
            btn_entrar.BackColor = corVerdePadrao;
        }

        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_cancel.BackColor = corAzulPadrao;
        }

        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel.BackColor = corVerdePadrao;
        }

        private void btn_info_MouseEnter(object sender, EventArgs e)
        {
            btn_info.BackColor = corAzulPadraoClaro;
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            btn_info.BackColor = corAzulPadraoForte;
        }
        #endregion

        DataTable dataTable = null;
        FormTelaInicial form_main;
        public FormLogin(FormTelaInicial form)
        {
            InitializeComponent();
            form_main = form;
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            //this.BackColor = corAzulPadrao;
            this.ForeColor = corControlLight;
            Banco.ConexaoBanco();
            CreateDataBase();
        }

        // TODO: TESTE BANCO NOVO - 
        private void CreateDataBase()
        {
            Globais.CreatePathBankTeste();
            string dataBaseCompletePath = $@"{Globais.caminhoBancoTESTE}{Globais.nomeBancoTESTE}";
            ConnectionBank.CreateDataBasesIfNotExists(dataBaseCompletePath);
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string userName = ktb_Login.Text;
            string password = ktb_senha.Text;

            if(userName == "" || password == "")
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ktb_Login.Focus();
                return;
            }

            dataTable = UsuarioController.obterLoginUsuario(userName, password);

            if (dataTable.Rows.Count == 1)
            {
                // usuario logado
                form_main.lb_idLogado.Text = dataTable.Rows[0].Field<Int64>("id_usuario").ToString();
                form_main.lb_UserLogado.Text = dataTable.Rows[0].Field<string>("nome_usuario");
                Globais.nivel = int.Parse(dataTable.Rows[0].Field<Int64>("nivel_de_acesso").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Usuário não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Status de acesso não permitido, consulte o admin", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ktb_Login.Focus();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main.Close();
        }
    }
}
