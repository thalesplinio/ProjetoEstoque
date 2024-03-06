using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form_Gerencia_Estoque : Form
    {
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
        private void btn_salvarAlteracao_MouseEnter(object sender, EventArgs e)
        {
            btn_salvarAlteracao.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_salvarAlteracao_MouseLeave(object sender, EventArgs e)
        {
            btn_salvarAlteracao.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_removeItem_MouseEnter(object sender, EventArgs e)
        {
            btn_removeItem.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_removeItem_MouseLeave(object sender, EventArgs e)
        {
            btn_removeItem.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_adicionaImagem_MouseEnter(object sender, EventArgs e)
        {
            btn_adicionaImagem.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_adicionaImagem_MouseLeave(object sender, EventArgs e)
        {
            btn_adicionaImagem.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        #region Globais
        string caminhoOrigem = "";
        string imagem = "";
        string pastaDestino = Globais.caminhoImageProduct;
        string destinoCompleto = "";
        #endregion

        public Form_Gerencia_Estoque()
        {
            InitializeComponent();
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
                // Apagando a imagem / se tiver foto apaga
                if (File.Exists(pictureBoxMostraItem.ImageLocation))
                {
                    File.Delete(pictureBoxMostraItem.ImageLocation);
                }
                // -----------------
                Banco.DeletarGerenciaProduto(tb_idProduto.Text);
                kryptonDataGridViewGerenciaProdutos.DataSource = Banco.ObterProdutosParaGerenciar();
                kryptonDataGridViewGerenciaProdutos.Sort(kryptonDataGridViewGerenciaProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            }
        }
        private void btn_salvarAlteracao_Click(object sender, EventArgs e)
        {
            #region Tratando nossa imagem do produto
            /// ----------------------------------------------------------------------------------------
            /// Aqui copiamos nossa imagem e mandamos para nossa pasta no local do sistema e colcoamos 
            /// a url dela no banco de dados
            //pictureBoxMostraItem.ImageLocation = null;
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Nenhuma imagem foi selecionada para o produto, deseja continuar?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(caminhoOrigem, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pictureBoxMostraItem.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO ao encontrar a imagem, deseja continuar?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            #endregion

            #region alterando produto no banco
            Produtos produtos = new Produtos();

            produtos.id_produto = tb_idProduto.Text;
            int.Parse(produtos.id_fornecedor = cb_Fornecedor.SelectedValue.ToString());
            produtos.nome = tb_nomeProduto.Text;
            produtos.marca = tb_marca.Text;
            produtos.quantidade = nud_qtd.Text;
            produtos.quantidade_minima = nud_minQtd.Text;
            int.Parse(produtos.id_categoria = cb_categoria.SelectedValue.ToString());
            int.Parse(produtos.id_tipo_produto = cb_tipo.SelectedValue.ToString());
            produtos.descricao = rtb_desc.Text;
            produtos.image = destinoCompleto;
            MessageBox.Show($"{produtos.image}");
            #endregion

            Banco.AtualizarGerenciaProdutos(produtos);
            kryptonDataGridViewGerenciaProdutos.DataSource = Banco.ObterProdutosParaListar();
            kryptonDataGridViewGerenciaProdutos.Sort(kryptonDataGridViewGerenciaProdutos.Columns["ID Produto"], ListSortDirection.Descending);
        }
        private void btn_adicionaImagem_Click(object sender, EventArgs e)
        {
            /// ----------------------------------------------------------------------------------------
            /// Aqui pegamos o arquivo e setamos ele no nosso picture box, mas usamos o caminho original
            /// no botao de salvar é aonde fazemos realmente a cópia do arquivo e mandamos o url desta
            /// imagem copiada para o banco de dados
            caminhoOrigem = "";
            imagem = "";
            pastaDestino = Globais.caminhoImageProduct;
            destinoCompleto = "";

            openFileDialogAlterProduct.Filter = "Imagens (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png";

            if (openFileDialogAlterProduct.ShowDialog() == DialogResult.OK)
            {
                caminhoOrigem = openFileDialogAlterProduct.FileName;   // retorna todo o caminho
                imagem = openFileDialogAlterProduct.SafeFileName;      // somente o nome do arquivo
                destinoCompleto = pastaDestino + imagem;                    // destino aonde ele vai ficar + nome do arquivo
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe no local de destino, deseja substituir?", "Substituir arquivo?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pictureBoxMostraItem.ImageLocation = caminhoOrigem;
        }
        private void tb_buscaPorNome_TextChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.nome = tb_buscaPorNome.Text;
            kryptonDataGridViewGerenciaProdutos.DataSource = Banco.BuscaNomeProduto(produtos.nome);
        }
    }
}
