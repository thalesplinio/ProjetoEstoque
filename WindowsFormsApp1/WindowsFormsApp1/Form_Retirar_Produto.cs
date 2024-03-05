using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class Form_Retirar_Produto : Form
    {
        public Form_Retirar_Produto()
        {
            InitializeComponent();
        }

        private void Form_Retirar_Produto_Load(object sender, EventArgs e)
        {
            ListaProdutosDGV();
            ContaProdutos();
        }
        private void ContaProdutos()
        {
            try
            {
                var dataTable = Banco.ObterQuantidade();
                int quantidadeTotal = Convert.ToInt32(dataTable.Rows[0][0]);
                lb_qtdProdutos.Text = $"{quantidadeTotal}";
            }
            catch 
            {
                lb_qtdProdutos.Text = "Nenhum produto registrado";
            }
        }
        private void ListaProdutosDGV()
        {
            kryptonDataGridViewRetiraProdutos.DataSource = Banco.ObterProdutosParaListar();
            kryptonDataGridViewRetiraProdutos.Sort(kryptonDataGridViewRetiraProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            kryptonDataGridViewRetiraProdutos.Columns[0].Width = 85;
            kryptonDataGridViewRetiraProdutos.Columns[1].Width = 110;
            kryptonDataGridViewRetiraProdutos.Columns[2].Width = 165;
            kryptonDataGridViewRetiraProdutos.Columns[3].Width = 110;
            kryptonDataGridViewRetiraProdutos.Columns[4].Width = 80;
            kryptonDataGridViewRetiraProdutos.Columns[5].Width = 80;
            kryptonDataGridViewRetiraProdutos.Columns[6].Width = 110;
            kryptonDataGridViewRetiraProdutos.Columns[7].Width = 110;
            kryptonDataGridViewRetiraProdutos.Columns[8].Width = 110;
            kryptonDataGridViewRetiraProdutos.Columns[9].Width = 100;
            kryptonDataGridViewRetiraProdutos.Columns[10].Width = 110;
        }

        private void kryptonDataGridViewRetiraProdutos_SelectionChanged(object sender, EventArgs e)
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

                    pictureBoxMostraProduto.ImageLocation = dataTable.Rows[0].Field<string>("image").ToString();
                    tb_idProduto.Text = dataTable.Rows[0].Field<Int64>("id_produto").ToString();
                    tb_idFornecedor.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[1].Value.ToString();
                    tb_nomeProduto.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[2].Value.ToString();
                    tb_marcaProduto.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[3].Value.ToString();
                    tb_quantidade.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[4].Value.ToString();
                    tb_quantidadeMinima.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[5].Value.ToString();
                    tb_categoriaProduto.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[6].Value.ToString();
                    tb_tipoProduto.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[7].Value.ToString();
                    tb_descProduto.Text = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[8].Value.ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void btn_retiraProduto_Click(object sender, EventArgs e)
        {
            string valorAntigo = kryptonDataGridViewRetiraProdutos.CurrentRow.Cells[4].Value.ToString();
            string valorNovo = tb_valorRetirada.Text;
            int num1 = int.Parse(valorAntigo);
            int num2 = int.Parse(valorNovo);

            if (num2 <= num1)
            {
                MessageBox.Show("O produto TEM essa quantidade!, confira a quantidade", "Mensagem");
                int soma = num1 - num2;
                Produtos produto = new Produtos();
                produto.id_produto = tb_idProduto.Text;
                Banco.AtualizarProdutoEstoque(produto, soma);
                ContaProdutos();
                tb_valorRetirada.Clear();
                tb_descRetirada.Clear();
                kryptonDataGridViewRetiraProdutos.DataSource = Banco.ObterProdutosParaListar();
                kryptonDataGridViewRetiraProdutos.Sort(kryptonDataGridViewRetiraProdutos.Columns["ID Produto"], ListSortDirection.Descending);
                int linhaSelecionada = kryptonDataGridViewRetiraProdutos.SelectedRows[0].Index;
                kryptonDataGridViewRetiraProdutos[0, linhaSelecionada].Value = tb_idProduto.Text;
                kryptonDataGridViewRetiraProdutos[1, linhaSelecionada].Value = tb_idFornecedor.Text;
            }
            else if (num2 >= num1)
            {
                if (num1 == 0)
                {
                    MessageBox.Show("Este produto está em falta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }

        private void tb_buscaPorNome_TextChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.nome = tb_buscaPorNome.Text;
            kryptonDataGridViewRetiraProdutos.DataSource = Banco.BuscaNomeProduto(produtos.nome);
        }
    }
}
