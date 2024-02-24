using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
