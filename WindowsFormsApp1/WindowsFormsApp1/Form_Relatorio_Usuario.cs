using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
using System.Drawing.Printing;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form_Relatorio_Usuario : Form
    {
        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
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
                lb_quantidadeInserida.Text = $"{quantidadeTotal}";
                lb_nomeUsuario.Text = produtos.id_usuario;
            }
            catch
            {
                lb_qtdInsertUsuario.Text = "Nenhum produto registrado";
            }
        }
        private void btn_novoFornecedor_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.id_usuario = tb_buscaNomeUsuarioRelatorio.Text;
            kryptonDataGridViewListaProdutosRelatorioUsuario.DataSource = Banco.BuscaNomeProdutoPorUsuarios(produtos.id_usuario);

            string nomeArquivo;
            saveFileDialogPDF.Title = "Salvar arquivo";
            saveFileDialogPDF.Filter = "pdf|*.pdf";

            if (saveFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                nomeArquivo = saveFileDialogPDF.FileName;
                #region Configuração das paginas 
                var pixelPorMilimetro = 72 / 25.2f;
                Document doc = new Document(PageSize.A4.Rotate(), 15 * pixelPorMilimetro, 15 * pixelPorMilimetro, 15 * pixelPorMilimetro, 20 * pixelPorMilimetro);
                var arquivo = new FileStream(nomeArquivo, FileMode.Create);
                var write = PdfWriter.GetInstance(doc, arquivo);
                doc.Open();

                #region Utilites
                fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 24, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                var fonteSubtitulo = new iTextSharp.text.Font(fonteBase, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                int tamanhoFontTituloTabela = 10;
                int tamanhoTabelaContent = 8;
                #endregion

                #region Titulo
                var titulo = new Paragraph("Controle de estoque\n", fonteParagrafo);
                titulo.Alignment = Element.ALIGN_LEFT;
                doc.Add(titulo);
                #endregion

                #region Subtitulo
                var subtitulo = new Paragraph("Resumo de relatórios de inserção de produtos por usuário.", fonteSubtitulo);
                subtitulo.Alignment = Element.ALIGN_LEFT;
                //subtitulo.SpacingAfter = 4; // adicionando espaço depois do paragrafo 2
                doc.Add(subtitulo);
                #endregion

                #region Subtitulo com nome de usuário
                var tituloNomeUsuario = new Paragraph($"Nome de usuário: {lb_nomeUsuario.Text}\nQuantidade inserido pelo usuário: {lb_quantidadeInserida.Text} registros.\n\n", fonteSubtitulo);
                tituloNomeUsuario.Alignment = Element.ALIGN_LEFT;
                //tituloNomeUsuario.SpacingAfter = 4; // adicionando espaço depois do paragrafo 2
                doc.Add(tituloNomeUsuario);
                #endregion

                #region Adicionando imagem
                var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Globais.caminhoIconeSitemaPDF);
                if (File.Exists(caminhoImagem))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoImagem);
                    float razaoAlturaLargura = logo.Width / logo.Height;
                    float alturaLogo = 32;
                    float larguraLogo = alturaLogo * razaoAlturaLargura;
                    logo.ScaleToFit(larguraLogo, alturaLogo);
                    var margemEsquerda = doc.PageSize.Width - doc.RightMargin - larguraLogo;
                    var margemTopo = doc.PageSize.Height - doc.TopMargin - 54;
                    logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                    doc.Add(logo); // adicionando a imagem do arquivo
                }
                #endregion

                #region Criando tabela do banco 

                var tabela = new PdfPTable(12);
                float[] larguraColunas = { 0.6f, 0.9f, 2f, 1f, 1.4f, 0.9f, 1.5f, 0.6f, 0.6f, 0.9f, 1.5f, 1.5f };
                tabela.SetWidths(larguraColunas);
                tabela.DefaultCell.BorderWidth = 1;
                tabela.WidthPercentage = 100;

                // Criando celulas
                CriarCelulaTexto(tabela, "Id Produto", PdfPCell.ALIGN_CENTER, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Usuário", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Nome Produto", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Fornecedor", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Marca Produto", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Categoria", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Descrição", PdfPCell.ALIGN_CENTER, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Quantidade total", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Qtd. Mínima", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Tipo de Produto", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Data Cadastro", PdfPCell.ALIGN_CENTER, false, false, tamanhoFontTituloTabela);
                CriarCelulaTexto(tabela, "Data Atualização", PdfPCell.ALIGN_LEFT, false, false, tamanhoFontTituloTabela);

                // Adicionando dados do banco
                DataTable dataTableProdutos = Banco.BuscaNomeProdutoPorUsuarios(produtos.id_usuario);
                for (int i = 0; i < dataTableProdutos.Rows.Count; i++)
                {
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<Int64>("Id Produto").ToString(), PdfPCell.ALIGN_CENTER, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Usuário").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Nome Produto").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Fornecedor").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Marca Produto").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Categoria").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Descrição").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<Int64>("Quantidade total").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<Int64>("Qtd. Mínima").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<string>("Tipo de Produto").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent);
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<DateTime?>("Data Cadastro").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent); // ? caso a data for null
                    CriarCelulaTexto(tabela, dataTableProdutos.Rows[i].Field<DateTime?>("Data Atualização").ToString(), PdfPCell.ALIGN_LEFT, false, false, tamanhoTabelaContent); // ? caso a data for null
                }
                doc.Add(tabela);
                #endregion


                doc.Close();
                DialogResult res = MessageBox.Show("Arquivo salvo com sucesso!\nDeseja abrir o relatório?", "Mensagem de abertura", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes) { System.Diagnostics.Process.Start($"{nomeArquivo}"); }
                #endregion
            }
        }
        private void CriarCelulaTexto(PdfPTable tabela, string texto, int alinhamentoHorizontal = PdfPCell.ALIGN_LEFT, bool negrito = false,
            bool italico = false, int tamanhoFonte = 12, int alturaCelula = 16)
        {
            int estilo = iTextSharp.text.Font.NORMAL;

            if (negrito & italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            // definindo aspecto zebrado das colunas
            var bgColor = iTextSharp.text.BaseColor.WHITE; // definindo toda tabela como branca
            if (tabela.Rows.Count % 2 == 1) // se a contagem de linhas for impar, recebe cinza claro.
            {
                bgColor = new BaseColor(0.95f, 0.95f, 0.95f);
            }

            var fonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte, estilo, BaseColor.BLACK);
            var celula = new PdfPCell(new Phrase(texto, fonteCelula));
            celula.HorizontalAlignment = alinhamentoHorizontal;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 0.5f;
            celula.FixedHeight = alturaCelula;
            celula.PaddingBottom = 1; // Corrigir alinhamento dos dados da tabela
            celula.BackgroundColor = bgColor; // definindo o aspecto zebrado na nossa tabela.
            tabela.AddCell(celula);
        }
    }
}
