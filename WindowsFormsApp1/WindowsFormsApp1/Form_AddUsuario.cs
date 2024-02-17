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
            public static Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
        }
        #endregion

        #region Buttons Hover Color

        #endregion

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
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
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

        private void btn_novoUsuario_Click(object sender, EventArgs e)
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
    }
}
