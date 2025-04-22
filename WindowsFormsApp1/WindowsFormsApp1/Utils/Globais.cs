using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Globais
    {
        public static string versao = "Feito por Thales Plinio V 1.0.0";
        public static bool logado = false;
        public static int nivel = 0;

        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_estoque.db";
        public static string caminhoBanco = $@"{caminho}\banco\";
        public static string caminhoImageProduct = $@"{caminho}\image_product\";

        public static string caminhoIconeSitemaPDF = $@"{caminho}\img\icone.png";


        public static string nomeBancoTESTE = "DBestoque.db";
        public static string caminhoBancoTESTE = $@"{caminho}\bancoTESTE\";

        public static void CreatePathBankTeste()
        {
            if (!Directory.Exists(caminhoBancoTESTE))
            {
                Directory.CreateDirectory(caminhoBancoTESTE);
            }
            else
            {
                MessageBox.Show("Não conseguimos criar a pasta do banco TESTE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
