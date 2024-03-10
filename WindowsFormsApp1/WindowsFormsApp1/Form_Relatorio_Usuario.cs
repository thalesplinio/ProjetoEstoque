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
    public partial class Form_Relatorio_Usuario : Form
    {
        public Form_Relatorio_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Relatorio_Usuario_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewListaProdutosRelatorioUsuario.DataSource = Banco.ObterProdutosParaParaRelatorioUsuario();
            kryptonDataGridViewListaProdutosRelatorioUsuario.Sort(kryptonDataGridViewListaProdutosRelatorioUsuario.Columns["ID Produto"], ListSortDirection.Descending);
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[0].Width = 85;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[1].Width = 90;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[2].Width = 185;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[3].Width = 100;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[4].Width = 100;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[5].Width = 100;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[6].Width = 140;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[7].Width = 75;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[8].Width = 75;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[9].Width = 100;
            kryptonDataGridViewListaProdutosRelatorioUsuario.Columns[10].Width = 110;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.id_usuario = tb_buscaNomeUsuarioRelatorio.Text;
            kryptonDataGridViewListaProdutosRelatorioUsuario.DataSource = Banco.BuscaNomeProdutoPorUsuarios(produtos.id_usuario);
            try
            {
                var dataTableCont = Banco.ObterQuantidadePorUsuario(produtos.id_usuario);
                int quantidadeTotal = Convert.ToInt32(dataTableCont.Rows[0][0]);
                lb_qtdInsertUsuario.Text = $"{quantidadeTotal}";
            }
            catch
            {
                lb_qtdInsertUsuario.Text = "Nenhum produto registrado";
            }
        }
    }
}
