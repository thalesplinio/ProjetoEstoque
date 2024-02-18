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
    public partial class Form_Todos_Usuarios : Form
    {
        public Form_Todos_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Todos_Usuarios_Load(object sender, EventArgs e)
        {
            lb_detalhesStatus.Text = "A = Ativo,\nB = Bloqueado,\nD = Desligado";
            tb_dataBanco.ForeColor = Color.Green;
            lb_dataAlteracaoCadastro.ForeColor = Color.Green;

            kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
            kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
            kryptonDataGridView1.Columns[0].Width = 80;
            kryptonDataGridView1.Columns[1].Width = 190;
            kryptonDataGridView1.Columns[2].Width = 140;
            kryptonDataGridView1.Columns[3].Width = 180;
            kryptonDataGridView1.Columns[4].Width = 100;
            kryptonDataGridView1.Columns[5].Width = 110;
            kryptonDataGridView1.Columns[6].Width = 90;
            kryptonDataGridView1.Columns[7].Width = 80;
            kryptonDataGridView1.Columns[8].Width = 100;
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

            Form_AddUsuario form_AddUsuario = new Form_AddUsuario();
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
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            Usuario usuario = new Usuario();
            usuario.id_usuario = Convert.ToInt32(tb_id.Text);
            usuario.nome_completo = tb_nomeCompleto.Text;
            usuario.nome_usuario = tb_nomeUsuario.Text;
            usuario.email = tb_email.Text;
            usuario.telefone = mtb_telefone.Text;
            usuario.senha = tb_senha.Text;
            usuario.usuario_ativo = cb_statusUsuario.Text;
            usuario.nivel_acesso = Convert.ToInt32(Math.Round(nud_nivelAcesso.Value, 0));   // 0 = para 0 casas decimais
            Banco.AtualizarUsuario(usuario);

            kryptonDataGridView1.DataSource = Banco.ObterDadosUsuarioBanco();
            kryptonDataGridView1.Sort(kryptonDataGridView1.Columns["ID Usuário"], ListSortDirection.Descending);
        }
    }
}
