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
    public partial class Form_AddUsuario : Form
    {
        public Form_AddUsuario()
        {
            InitializeComponent();
        }
        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            public static Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D

            public static Color corControl = Color.FromArgb(240, 240, 240);
            public static Color corControlLight = Color.FromArgb(227, 227, 227);
        }
        #endregion

        #region Buttons Hover Color
        private void btn_novoUsuario_MouseEnter(object sender, EventArgs e)
        {
            btn_novoUsuario.BackColor = RGBColorsButtons.corVerdePadrao;
        }
        private void btn_novoUsuario_MouseLeave(object sender, EventArgs e)
        {
            btn_novoUsuario.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        private void btn_Salvar_MouseEnter(object sender, EventArgs e)
        {
            btn_Salvar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_Salvar_MouseLeave(object sender, EventArgs e)
        {
            btn_Salvar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        private void btn_addStatus_MouseEnter(object sender, EventArgs e)
        {
            btn_addStatus.BackColor = RGBColorsButtons.corVerdePadrao;
        }
        private void btn_addStatus_MouseLeave(object sender, EventArgs e)
        {
            btn_addStatus.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        private void btn_info_MouseEnter(object sender, EventArgs e)
        {
            btn_info.BackColor = RGBColorsButtons.corControlLight;
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            btn_info.BackColor = RGBColorsButtons.corControl;
        }

        #endregion

        private void Form_AddUsuario_Load(object sender, EventArgs e)
        {

            string vQueryStatus = @"SELECT nome_status FROM status_usuario";
            cb_statusUsuario.Items.Clear();
            cb_statusUsuario.DataSource = Banco.Consulta(vQueryStatus);
            cb_statusUsuario.DisplayMember = "nome_status";
            cb_statusUsuario.ValueMember = "nome_status";
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Criando novo usuário
            Usuario usuario = new Usuario();
            usuario.nome_completo = tb_nomeCompleto.Text;
            usuario.nome_usuario = tb_nomeUsuario.Text;
            usuario.email = tb_email.Text;
            usuario.telefone = mtb_telefone.Text;
            usuario.senha = tb_senha.Text;

            string rSenha = tb_repeteSenha.Text;

            usuario.usuario_ativo = cb_statusUsuario.Text;
            usuario.nivel_acesso = Convert.ToInt32(Math.Round(nud_nivelAcesso.Value,0));    // 0 = zero casas decimais

            Banco.NovoUsuario(usuario);
            LimpaCampos();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            this.Close();
        }
        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            tb_nomeCompleto.Clear();
            tb_nomeUsuario.Clear();
            tb_email.Clear();
            mtb_telefone.Clear();
            tb_senha.Clear();
            tb_repeteSenha.Clear();
            cb_statusUsuario.Text = "";
            nud_nivelAcesso.Value = 0;
            tb_nomeCompleto.Focus();
        }
        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            Form_AddStatus form_AddStatus = new Form_AddStatus();
            form_AddStatus.ShowDialog();
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            Form_DeskNivel form_DeskNivel = new Form_DeskNivel();
            form_DeskNivel.ShowDialog();
        }
    }
}
