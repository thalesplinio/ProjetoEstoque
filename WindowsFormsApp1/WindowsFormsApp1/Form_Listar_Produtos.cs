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
    public partial class Form_Listar_Produtos : Form
    {
        public Form_Listar_Produtos()
        {
            InitializeComponent();
        }
        private void Listar_Produtos_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewListaProdutos.DataSource = Banco.ObterProdutosParaListar();
            kryptonDataGridViewListaProdutos.Sort(kryptonDataGridViewListaProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            kryptonDataGridViewListaProdutos.Columns[0].Width = 85;
            kryptonDataGridViewListaProdutos.Columns[1].Width = 110;
            kryptonDataGridViewListaProdutos.Columns[2].Width = 165;
            kryptonDataGridViewListaProdutos.Columns[3].Width = 110;
            kryptonDataGridViewListaProdutos.Columns[4].Width = 80;
            kryptonDataGridViewListaProdutos.Columns[5].Width = 80;
            kryptonDataGridViewListaProdutos.Columns[6].Width = 110;
            kryptonDataGridViewListaProdutos.Columns[7].Width = 110;
            kryptonDataGridViewListaProdutos.Columns[8].Width = 110;
            kryptonDataGridViewListaProdutos.Columns[9].Width = 100;
            kryptonDataGridViewListaProdutos.Columns[10].Width = 110;
            ContaProdutos();
        }
        private void kryptonDataGridViewListaProdutos_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string idProduto = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosParaVisualizarProdutos(idProduto);

                tb_idProduto.Text = dataTable.Rows[0].Field<Int64>("id_produto").ToString();
                pictureBoxMostraItem.ImageLocation = dataTable.Rows[0].Field<string>("image").ToString();
            }
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

        private void tb_buscaPorNome_TextChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.nome = tb_buscaPorNome.Text;
            kryptonDataGridViewListaProdutos.DataSource = Banco.BuscaNomeProduto(produtos.nome);
        }
    }
}
