using Krypton.Toolkit;
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
    public partial class Form_Fornecedores : Form
    {
        public Form_Fornecedores()
        {
            InitializeComponent();
        }
        private void LimpaCampos()
        {
            tb_idFornecedor.Clear();
            tb_nomeFornecedor.Clear();
            tb_cnpjFornecedor.Clear();
            tb_enderecoFornecedor.Clear();
            mtb_telefoneFornecedor.Clear();
            tb_emailFornecedor.Clear();
        }
        private void Form_Fornecedores_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewFornecedor.DataSource = Banco.ObterFornecedor();
            kryptonDataGridViewFornecedor.Sort(kryptonDataGridViewFornecedor.Columns["ID Fornecedor"], ListSortDirection.Descending);
            kryptonDataGridViewFornecedor.Columns[0].Width = 90;
            kryptonDataGridViewFornecedor.Columns[1].Width = 170;
            kryptonDataGridViewFornecedor.Columns[2].Width = 90;
            kryptonDataGridViewFornecedor.Columns[3].Width = 140;
            kryptonDataGridViewFornecedor.Columns[4].Width = 100;
            kryptonDataGridViewFornecedor.Columns[5].Width = 140;
            kryptonDataGridViewFornecedor.Columns[6].Width = 100;

        }

        private void btn_novoFornecedor_Click(object sender, EventArgs e)
        {
            Form_AddFornecedor form_AddFornecedor = new Form_AddFornecedor();
            form_AddFornecedor.ShowDialog();
            kryptonDataGridViewFornecedor.DataSource = Banco.ObterFornecedor();
            kryptonDataGridViewFornecedor.Sort(kryptonDataGridViewFornecedor.Columns["ID Fornecedor"], ListSortDirection.Descending);
        }

        private void btn_SalvarFornecedor_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = kryptonDataGridViewFornecedor.SelectedRows[0].Index;
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.id_fornecedor = Convert.ToInt32(tb_idFornecedor.Text);
            fornecedor.nome = tb_nomeFornecedor.Text;
            fornecedor.cnpj = tb_cnpjFornecedor.Text;
            fornecedor.endereco = tb_enderecoFornecedor.Text;
            fornecedor.telefone = mtb_telefoneFornecedor.Text;
            fornecedor.email = tb_emailFornecedor.Text;

            Banco.AtualizarFornecedor(fornecedor);
            LimpaCampos();

            kryptonDataGridViewFornecedor.DataSource = Banco.ObterFornecedor();
            kryptonDataGridViewFornecedor.Sort(kryptonDataGridViewFornecedor.Columns["ID Fornecedor"], ListSortDirection.Descending);
            kryptonDataGridViewFornecedor.CurrentCell = kryptonDataGridViewFornecedor[0, linhaSelecionada];

        }

        private void kryptonDataGridViewFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string idFornecedor = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosStatusParaEdicaoFornecedor(idFornecedor);

                tb_idFornecedor.Text = dataTable.Rows[0].Field<Int64>("id_fornecedor").ToString();
                tb_nomeFornecedor.Text = dataTable.Rows[0].Field<string>("nome").ToString();
                tb_cnpjFornecedor.Text = dataTable.Rows[0].Field<string>("cnpj").ToString();
                tb_enderecoFornecedor.Text = dataTable.Rows[0].Field<string>("endereco").ToString();
                mtb_telefoneFornecedor.Text = dataTable.Rows[0].Field<string>("telefone").ToString();
                tb_emailFornecedor.Text = dataTable.Rows[0].Field<string>("email").ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Deseja realmente excluir este fornecedor do sistema?", 
                "Confirmar exclusão", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Banco.ExcluirFornecedor(tb_idFornecedor.Text);
                kryptonDataGridViewFornecedor.DataSource = Banco.ObterFornecedor();
                kryptonDataGridViewFornecedor.Sort(kryptonDataGridViewFornecedor.Columns["ID Fornecedor"], ListSortDirection.Descending);
            }
        }
    }

}
