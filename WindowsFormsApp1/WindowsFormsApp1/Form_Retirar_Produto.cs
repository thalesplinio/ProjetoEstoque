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
            var dataTable = Banco.ObterQuantidade();
            int quantidadeTotal = Convert.ToInt32(dataTable.Rows[0][0]);
            lb_qtdProdutos.Text = $"{quantidadeTotal}";
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
        }
    }
}
