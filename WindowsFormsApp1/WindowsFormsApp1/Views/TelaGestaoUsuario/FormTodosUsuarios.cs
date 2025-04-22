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
using WindowsFormsApp1.Models.Usuario.Enum;

namespace WindowsFormsApp1
{
    public partial class FormTodosUsuarios : Form
    {
        public FormTodosUsuarios()
        {
            InitializeComponent();
        }
        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            //public static Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
            public static Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D


            public static Color corControl = Color.FromArgb(240, 240, 240);
            public static Color corControlLight = Color.FromArgb(227, 227, 227);

        }
        #endregion

        #region Buttons Hover Color
        private void btn_info_MouseEnter(object sender, EventArgs e)
        {
            btn_info.BackColor = RGBColorsButtons.corControlLight;
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            btn_info.BackColor = RGBColorsButtons.corControl;
        }
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
        private void btn_ExluirUsuario_MouseEnter(object sender, EventArgs e)
        {
            btn_ExluirUsuario.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_ExluirUsuario_MouseLeave(object sender, EventArgs e)
        {
            btn_ExluirUsuario.BackColor = RGBColorsButtons.corAzulPadrao;

        }

        private void btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void Form_Todos_Usuarios_Load(object sender, EventArgs e)
        {
            tb_dataBanco.ForeColor = Color.Green;
            lb_dataAlteracaoCadastro.ForeColor = Color.Green;

            kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
            kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
            kryptonDataGridView1.Columns[0].Width = 90;
            kryptonDataGridView1.Columns[1].Width = 190;
            kryptonDataGridView1.Columns[2].Width = 120;
            kryptonDataGridView1.Columns[3].Width = 180;
            kryptonDataGridView1.Columns[4].Width = 100;
            kryptonDataGridView1.Columns[5].Width = 107;
            kryptonDataGridView1.Columns[6].Width = 110;
            kryptonDataGridView1.Columns[7].Width = 80;
            kryptonDataGridView1.Columns[8].Width = 120;

            //string vQueryStatus = @"SELECT nome_status FROM status_usuario";
            //cb_statusUsuario.Items.Clear();
            //cb_statusUsuario.DataSource = Enum.GetValues(typeof(EnumStatusUsuario));
            //cb_statusUsuario.DisplayMember = "nome_status";
            //cb_statusUsuario.ValueMember = "nome_status";
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            tb_nomeCompleto.Clear();
            tb_nomeUsuario.Clear();
            tb_email.Clear();
            mtb_telefone.Clear();
            cb_statusUsuario.Text = "";
            nud_nivelAcesso.Value = 0;
            tb_nomeCompleto.Focus();

            FormAdicionarUsuario form_AddUsuario = new FormAdicionarUsuario();
            form_AddUsuario.ShowDialog();
            kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
            kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
        }
        private void kryptonDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0) 
            {
                DataTable dataTable = new DataTable();
                string idUsuario = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosParaEdicao(idUsuario);        
                
                tb_id.Text = dataTable.Rows[0].Field<Int64>("id_usuario").ToString();
                tb_nomeCompleto.Text = dataTable.Rows[0].Field<string>("nome_completo").ToString();
                tb_nomeUsuario.Text = dataTable.Rows[0].Field<string>("nome_usuario").ToString();
                tb_email.Text = dataTable.Rows[0].Field<string>("email").ToString();
                mtb_telefone.Text = dataTable.Rows[0].Field<string>("telefone").ToString();
                tb_senha.Text = dataTable.Rows[0].Field<string>("senha").ToString();
                tb_dataBanco.Text = dataTable.Rows[0].Field<DateTime>("data_cadastro").ToString();
                cb_statusUsuario.Text = dataTable.Rows[0].Field<string>("usuario_ativo").ToString();
                nud_nivelAcesso.Value = dataTable.Rows[0].Field<Int64>("nivel_acesso");

                try
                {
                    lb_dataAlteracaoCadastro.Text = dataTable.Rows[0].Field<DateTime>("data_atualizacao").ToString();
                }
                catch 
                {
                    lb_dataAlteracaoCadastro.Text = "-- Cadastro inda não foi atualizado";
                }
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = kryptonDataGridView1.SelectedRows[0].Index;

            UsuarioModel usuario = new UsuarioModel();

            usuario.IdUsuario = Convert.ToInt32(tb_id.Text);
            usuario.NomeCompleto = tb_nomeCompleto.Text;
            usuario.NomeDeUsuario = tb_nomeUsuario.Text;
            usuario.Email = tb_email.Text;
            usuario.Telefone = mtb_telefone.Text;
            usuario.Senha = tb_senha.Text;

            usuario.StatusUsuario = (EnumStatusUsuario)cb_statusUsuario.SelectedItem;
            usuario.NivelDeAcesso = (EnumNivelDeAcesso)cb_statusUsuario.SelectedItem;

            UsuarioController.NovoUsuario(usuario);

            kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
            kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
            kryptonDataGridView1.CurrentCell = kryptonDataGridView1[0, linhaSelecionada];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
                kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
            }
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            FormDescricaoDeNivelAcesso form_DeskNivel = new FormDescricaoDeNivelAcesso();
            form_DeskNivel.ShowDialog();
        }
    }
}
