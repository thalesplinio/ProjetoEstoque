using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form_Cadastro : Form
    {
        // Globais
        string caminhoOrigem = "";
        string imagem = "";
        string pastaDestino = Globais.caminhoImageProduct;
        string destinoCompleto = "";

        Form_Main form_main;
        public Form_Cadastro(Form_Main f)
        {
            InitializeComponent();
            form_main = f;
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
        private void btn_limpaCampos_MouseEnter(object sender, EventArgs e)
        {
            btn_limpaCampos.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_limpaCampos_MouseLeave(object sender, EventArgs e)
        {
            btn_limpaCampos.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_insereProduto_MouseEnter(object sender, EventArgs e)
        {
            btn_insereProduto.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_insereProduto_MouseLeave(object sender, EventArgs e)
        {
            btn_insereProduto.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void Form_Cadastro_Load(object sender, EventArgs e)
        {
            DataFornecedor();
            DataCategoria();
            DataTipo();

            kryptonDataGridViewCadastroProdutos.DataSource = Banco.ObterProdutos();
            kryptonDataGridViewCadastroProdutos.Sort(kryptonDataGridViewCadastroProdutos.Columns["ID Produto"], ListSortDirection.Descending);
        }
        private void DataFornecedor()
        {
            string vQueryFornecedor = @"SELECT id_fornecedor, nome FROM fornecedor_produto ORDER BY id_fornecedor";
            cb_Fornecedor.Items.Clear();
            cb_Fornecedor.Sorted = true;
            cb_Fornecedor.MaxDropDownItems = 8;
            cb_Fornecedor.IntegralHeight = false;
            cb_Fornecedor.DataSource = Banco.Consulta(vQueryFornecedor);
            cb_Fornecedor.DisplayMember = "nome";
            cb_Fornecedor.ValueMember = "id_fornecedor";
        }
        private void DataCategoria()
        {
            string vQueryCategoria = @"SELECT id_categoria, nome_categoria FROM categoria_produto ORDER BY id_categoria";
            cb_categoria.Items.Clear();
            cb_categoria.Sorted = true;
            cb_categoria.MaxDropDownItems = 8;
            cb_categoria.IntegralHeight = false;
            cb_categoria.DataSource = Banco.Consulta(vQueryCategoria);
            cb_categoria.DisplayMember = "nome_categoria";
            cb_categoria.ValueMember = "id_categoria";
        }
        private void DataTipo()
        {
            string vQueryTipo = @"SELECT id_tipo, nome_tipo FROM tipo_produto ORDER BY id_tipo";
            cb_tipo.Items.Clear();
            cb_tipo.Sorted = true;
            cb_tipo.MaxDropDownItems = 8;
            cb_tipo.IntegralHeight = false;
            cb_tipo.DataSource = Banco.Consulta(vQueryTipo);
            cb_tipo.DisplayMember = "nome_tipo";
            cb_tipo.ValueMember = "id_tipo";
        }

        private void btn_pegaUrl_Click(object sender, EventArgs e)
        {
            /// ----------------------------------------------------------------------------------------
            /// Aqui pegamos o arquivo e setamos ele no nosso picture box, mas usamos o caminho original
            /// no botao de salvar é aonde fazemos realmente a cópia do arquivo e mandamos o url desta
            /// imagem copiada para o banco de dados
            caminhoOrigem = "";
            imagem = "";
            pastaDestino = Globais.caminhoImageProduct;
            destinoCompleto = "";

            openFileDialogIsertImageProduct.Filter = "Imagens (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png";

            if (openFileDialogIsertImageProduct.ShowDialog() == DialogResult.OK)
            {
                caminhoOrigem = openFileDialogIsertImageProduct.FileName;   // retorna todo o caminho
                imagem = openFileDialogIsertImageProduct.SafeFileName;      // somente o nome do arquivo
                destinoCompleto = pastaDestino + imagem;                    // destino aonde ele vai ficar + nome do arquivo
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe no local de destino, deseja substituir?", "Substituir arquivo?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pictureBoxImageProduto.ImageLocation = caminhoOrigem;
        }

        private void btn_insereProduto_Click(object sender, EventArgs e)
        {
            #region Tratando nossa imagem do produto
            /// ----------------------------------------------------------------------------------------
            /// Aqui copiamos nossa imagem e mandamos para nossa pasta no local do sistema e colcoamos 
            /// a url dela no banco de dados
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
                    pictureBoxImageProduto.ImageLocation = destinoCompleto;
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

            #region Inserindo produto
            Produtos produto = new Produtos();
            int.Parse(produto.id_fornecedor = cb_Fornecedor.SelectedValue.ToString());
            produto.id_usuario = form_main.lb_UserLogado.Text;
            produto.nome = tb_nomeProduto.Text;
            produto.marca = tb_marca.Text;
            produto.quantidade = nud_qtd.Text;
            produto.quantidade_minima = nud_minQtd.Text;
            int.Parse(produto.id_categoria = cb_categoria.SelectedValue.ToString());
            int.Parse(produto.id_tipo_produto = cb_tipo.SelectedValue.ToString());
            produto.descricao = rtb_desc.Text;
            produto.image = destinoCompleto;

            Banco.AdicionarProduto(produto);
            #endregion
            kryptonDataGridViewCadastroProdutos.DataSource = Banco.ObterProdutos();
            kryptonDataGridViewCadastroProdutos.Sort(kryptonDataGridViewCadastroProdutos.Columns["ID Produto"], ListSortDirection.Descending);
        }
    }
}
