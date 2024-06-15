using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class EventosDePaginaPdf : PdfPageEventHelper
    {
        // fonte de rodapé
        private BaseFont fonteBaseRodape { get; set; }
        private iTextSharp.text.Font fonteRodape { get; set; }
        public int totalPaginas { get; set; }

        // Metodo construtor de inicialização das fontes
        public EventosDePaginaPdf(int totalPaginas)
        {
            fonteBaseRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fonteRodape = new iTextSharp.text.Font(fonteBaseRodape, 8f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            this.totalPaginas = totalPaginas;
        }
        // sobrescrição do evento de página quando uma página é finalizada
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            InformacoesAdicionais(writer, document);
            AdicionarMomentoGeracaoRelatorio(writer, document);
            AdicionarNumerosDePaginas(writer, document);
        }
        private void InformacoesAdicionais(PdfWriter writer, Document document)
        {
            var informacaoContato = $"Para mais informações entre em contato com a diretoria - (67) 98989 0009 - WebSite: https://github.com/thalesplinio";
            writer.DirectContent.BeginText();   // iniciando um texto
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);    // definindo familia da fonte e tamanho
            writer.DirectContent.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.95f); // posição da escrita
            writer.DirectContent.ShowText(informacaoContato);     // mostrando texto criado
            writer.DirectContent.EndText();     // finalizando
        }
        private void AdicionarMomentoGeracaoRelatorio(PdfWriter writer, Document document)
        {
            // Personalizando 
            var textoMomentoGeracao = $"Gerado em {DateTime.Now.ToShortDateString()} às {DateTime.Now.ToShortTimeString()}";
            // escrevendo corretamente no rodapé
            writer.DirectContent.BeginText();   // iniciando um texto
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);    // definindo familia da fonte e tamanho
            writer.DirectContent.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.75f); // posição da escrita
            writer.DirectContent.ShowText(textoMomentoGeracao);     // mostrando texto criado
            writer.DirectContent.EndText();     // finalizando
        }
        private void AdicionarNumerosDePaginas(PdfWriter writer, Document document)
        {
            int paginaAtual = writer.PageNumber;
            var textoPaginacao = $"Página {paginaAtual} de {totalPaginas}";

            // Setando posição
            float larguraTextoPaginacao = fonteBaseRodape.GetWidthPoint(textoPaginacao, fonteRodape.Size);
            var tamanhoPagina = document.PageSize;

            writer.DirectContent.BeginText();   // iniciando um texto
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);    // definindo familia da fonte e tamanho
            //                                largura total pagina/ - margem direita     - larguraTextoPaginacao   margem inferior mantem a mesma
            writer.DirectContent.SetTextMatrix(tamanhoPagina.Width - document.RightMargin - larguraTextoPaginacao, document.BottomMargin * 0.75f); // posição da escrita
            writer.DirectContent.ShowText(textoPaginacao);     // mostrando texto criado
            writer.DirectContent.EndText();     // finalizando
        }
    }
}
