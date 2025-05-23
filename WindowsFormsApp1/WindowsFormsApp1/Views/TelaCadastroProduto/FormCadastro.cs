﻿using System;
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
    public partial class FormCadastro : Form
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

        FormTelaInicial form_main;
        public FormCadastro(FormTelaInicial f)
        {
            InitializeComponent();
            form_main = f;
        }
        private void LimparCampos()
        {
            tb_nomeProduto.Clear();
            tb_marca.Clear();
            nud_qtd.Value = 0;
            nud_minQtd.Value = 0;
            rtb_desc.Clear();
            pictureBoxImageProduto.Image = null;
        }
        private void Form_Cadastro_Load(object sender, EventArgs e)
        {
            DataFornecedor();
            DataCategoria();
            DataTipo();
            kryptonDataGridViewCadastroProdutos.DataSource = Banco.ObterProdutos();
            kryptonDataGridViewCadastroProdutos.Sort(kryptonDataGridViewCadastroProdutos.Columns["ID Produto"], ListSortDirection.Descending);
            kryptonDataGridViewCadastroProdutos.Columns[0].Width = 85;
            kryptonDataGridViewCadastroProdutos.Columns[1].Width = 110;
            kryptonDataGridViewCadastroProdutos.Columns[2].Width = 165;
            kryptonDataGridViewCadastroProdutos.Columns[3].Width = 110;
            kryptonDataGridViewCadastroProdutos.Columns[4].Width = 80;
            kryptonDataGridViewCadastroProdutos.Columns[5].Width = 80;
            kryptonDataGridViewCadastroProdutos.Columns[6].Width = 110;
            kryptonDataGridViewCadastroProdutos.Columns[7].Width = 110;
            kryptonDataGridViewCadastroProdutos.Columns[8].Width = 110;
            kryptonDataGridViewCadastroProdutos.Columns[9].Width = 100;
            kryptonDataGridViewCadastroProdutos.Columns[10].Width = 110;
            Banco.ObterCategoria();
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
                if (MessageBox.Show("Nenhuma imagem foi selecionada para o produto, deseja continuar?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
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

            #region tratando campos
            if (tb_nomeProduto.Text == "")
            {
                label_tituloNomeProduto.ForeColor = Color.Red;
                label_tituloNomeProduto.Text = "Nome do produto: *";
            }
            else if (tb_marca.Text == "")
            {
                label_tituloNomeMarca.ForeColor = Color.Red;
                label_tituloNomeMarca.Text = "Marca: *";
            }
            else if (nud_qtd.Value == 0)
            {
                label_tituloNomeQtd.ForeColor = Color.Red;
                label_tituloNomeQtd.Text = "Quantidade do produto: *";
            }
            else if (nud_minQtd.Value == 0)
            {
                label_tituloNomeQtdMin.ForeColor = Color.Red;
                label_tituloNomeQtdMin.Text = "Quantidade mínima em estoque: *";
            }
            else
            {
                #region Inserindo produto
                ProdutosModel produto = new ProdutosModel();

                int.Parse(produto.id_fornecedor = cb_Fornecedor.SelectedValue.ToString());
                produto.id_usuario = form_main.lb_idLogado.Text;
                produto.nome = tb_nomeProduto.Text;
                produto.marca = tb_marca.Text;
                produto.quantidade = nud_qtd.Text;
                produto.quantidade_minima = nud_minQtd.Text;
                int.Parse(produto.id_categoria = cb_categoria.SelectedValue.ToString());
                int.Parse(produto.id_tipo_produto = cb_tipo.SelectedValue.ToString());
                produto.descricao = rtb_desc.Text;
                produto.image = destinoCompleto;

                Banco.AdicionarProduto(produto);
                LimparCampos();
                label_tituloNomeProduto.ForeColor = Color.Black;
                label_tituloNomeMarca.ForeColor = Color.Black;
                label_tituloNomeQtd.ForeColor = Color.Black;
                label_tituloNomeQtdMin.ForeColor = Color.Black;
                #endregion
            }
            #endregion
            kryptonDataGridViewCadastroProdutos.DataSource = Banco.ObterProdutos();
            kryptonDataGridViewCadastroProdutos.Sort(kryptonDataGridViewCadastroProdutos.Columns["ID Produto"], ListSortDirection.Descending);
        }
        private void btn_limpaCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
