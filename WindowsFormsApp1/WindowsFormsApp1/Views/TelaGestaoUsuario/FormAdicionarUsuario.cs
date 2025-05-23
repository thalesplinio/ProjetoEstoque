﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models.Usuario.Enum;

namespace WindowsFormsApp1
{
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
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
            UsuarioModel usuario = new UsuarioModel();
            usuario.NomeCompleto = tb_nomeCompleto.Text;
            usuario.NomeDeUsuario = tb_nomeUsuario.Text;
            usuario.Email = tb_email.Text;
            usuario.Telefone = mtb_telefone.Text;
            usuario.Senha = tb_senha.Text;

            string rSenha = tb_repeteSenha.Text;

            usuario.StatusUsuario = (EnumStatusUsuario)cb_statusUsuario.SelectedItem;
            usuario.NivelDeAcesso = (EnumNivelDeAcesso)cb_nivelAcesso.SelectedItem;    // 0 = zero casas decimais

            //Banco.NovoUsuario(usuario);
            UsuarioController.NovoUsuario(usuario);
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
            cb_nivelAcesso.Text = "";
            tb_nomeCompleto.Focus();
        }
        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus form_AddStatus = new FormAddStatus();
            form_AddStatus.ShowDialog();
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            FormDescricaoDeNivelAcesso form_DeskNivel = new FormDescricaoDeNivelAcesso();
            form_DeskNivel.ShowDialog();
        }
    }
}
