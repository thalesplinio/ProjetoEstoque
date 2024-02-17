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
    public partial class Form_Login : Form
    {
        #region Set Colors Butons
        public Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
        public Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D

        public Color corControl = Color.FromArgb(240, 240, 240);
        public Color corControlLight = Color.FromArgb(227, 227, 227);
        #endregion

        DataTable dataTable = null;

        Form_Main form_main;
        public Form_Login(Form_Main form)
        {
            InitializeComponent();
            form_main = form;
        }

        #region Buttons color Hover
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_entrar.BackColor = corVerdePadrao;
        }

        private void btn_entrar_MouseLeave(object sender, EventArgs e)
        {
            btn_entrar.BackColor = corAzulPadrao;
        }

        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_cancel.BackColor = corVerdePadrao;
        }

        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel.BackColor = corAzulPadrao;
        }

        private void btn_info_MouseEnter(object sender, EventArgs e)
        {
            btn_info.BackColor = corControlLight;
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            btn_info.BackColor = corControl;
        }
        #endregion

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

            string sqlQuery = @"SELECT * FROM usuarios WHERE nome_usuario='"+userName+"' AND senha='"+password+"'";
            dataTable = Banco.Consulta(sqlQuery);

            // 1 = logado
            // 0 = nao encontrado
            if(dataTable.Rows.Count == 1)
            {
                // usuario logado
                form_main.lb_UserLogado.Text = dataTable.Rows[0].Field<string>("nome_usuario");
                Globais.nivel = int.Parse(dataTable.Rows[0].Field<Int64>("nivel_acesso").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ktb_Login.Focus();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
