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
    public partial class Form_Gerencia_Estoque : Form
    {
        public Form_Gerencia_Estoque()
        {
            InitializeComponent();
        }
        private void DataFornecedor()
        {
            string vQueryFornecedor = @"SELECT id_fornecedor, nome FROM fornecedor_produto ORDER BY id_fornecedor";
            cb_Fornecedor.Items.Clear();
            //cb_Fornecedor.Sorted = true;
            //cb_Fornecedor.MaxDropDownItems = 8;
            //cb_Fornecedor.IntegralHeight = false;
            cb_Fornecedor.DataSource = Banco.Consulta(vQueryFornecedor);
            cb_Fornecedor.DisplayMember = "nome";
            cb_Fornecedor.ValueMember = "id_fornecedor";
        }
        private void DataCategoria()
        {
            string vQueryCategoria = @"SELECT id_categoria, nome_categoria FROM categoria_produto ORDER BY id_categoria";
            cb_categoria.Items.Clear();
            cb_categoria.DataSource = Banco.Consulta(vQueryCategoria);
            cb_categoria.DisplayMember = "nome_categoria";
            cb_categoria.ValueMember = "id_categoria";
        }
        private void DataTipo()
        {
            string vQueryTipo = @"SELECT id_tipo, nome_tipo FROM tipo_produto ORDER BY id_tipo";
            cb_tipo.Items.Clear();
            cb_tipo.DataSource = Banco.Consulta(vQueryTipo);
            cb_tipo.DisplayMember = "nome_tipo";
            cb_tipo.ValueMember = "id_tipo";
        }
        private void ContaProdutos()
        {
            try
            {
                var dataTable = Banco.ObterQuantidade();
                int quantidadeTotal = Convert.ToInt32(dataTable.Rows[0][0]);
                tb_itemEstoque.Text = $"{quantidadeTotal}";
            }
            catch
            {
                tb_itemEstoque.Text = "Nenhum produto registrado";
            }
        }
        private void Form_Gerencia_Estoque_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewGerenciaProdutos.DataSource = Banco.ObterProdutosParaListar();
            kryptonDataGridViewGerenciaProdutos.Sort(kryptonDataGridViewGerenciaProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            kryptonDataGridViewGerenciaProdutos.Columns[0].Width = 85;
            kryptonDataGridViewGerenciaProdutos.Columns[1].Width = 110;
            kryptonDataGridViewGerenciaProdutos.Columns[2].Width = 185;
            kryptonDataGridViewGerenciaProdutos.Columns[3].Width = 110;
            kryptonDataGridViewGerenciaProdutos.Columns[4].Width = 80;
            kryptonDataGridViewGerenciaProdutos.Columns[5].Width = 80;
            kryptonDataGridViewGerenciaProdutos.Columns[6].Width = 110;
            kryptonDataGridViewGerenciaProdutos.Columns[7].Width = 110;
            kryptonDataGridViewGerenciaProdutos.Columns[8].Width = 170;
            kryptonDataGridViewGerenciaProdutos.Columns[9].Width = 100;
            kryptonDataGridViewGerenciaProdutos.Columns[10].Width = 110;
            ContaProdutos();
            DataFornecedor();
            DataCategoria();
            DataTipo();
        }

        private void kryptonDataGridViewGerenciaProdutos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    string idProduto = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                    dataTable = Banco.ObterDadosParaVisualizarProdutos(idProduto);

                    pictureBoxMostraItem.ImageLocation = dataTable.Rows[0].Field<string>("image").ToString();
                    tb_idProduto.Text = dataTable.Rows[0].Field<Int64>("id_produto").ToString();
                    cb_Fornecedor.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[1].Value.ToString();
                    tb_nomeProduto.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[2].Value.ToString();
                    tb_marca.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[3].Value.ToString();
                    nud_qtd.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[4].Value.ToString();
                    nud_minQtd.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[5].Value.ToString();
                    cb_categoria.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[6].Value.ToString();
                    cb_tipo.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[7].Value.ToString();
                    rtb_desc.Text = kryptonDataGridViewGerenciaProdutos.CurrentRow.Cells[8].Value.ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Banco.DeletarGerenciaProduto(tb_idProduto.Text);

                kryptonDataGridViewGerenciaProdutos.DataSource = Banco.ObterProdutosParaGerenciar();
                kryptonDataGridViewGerenciaProdutos.Sort(kryptonDataGridViewGerenciaProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            }
        }

        private void btn_salvarAlteracao_Click(object sender, EventArgs e)
        {

        }
    }
}
