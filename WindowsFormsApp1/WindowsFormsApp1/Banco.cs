using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// --
using System.Data.SQLite;
using System.Data;


namespace WindowsFormsApp1
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        #region Conexao banco
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = E:\\Documentos\\0 - Documentos\\GitHub\\ProjetoEstoque\\WindowsFormsApp1\\WindowsFormsApp1\\banco\\banco_estoque.db");
            conexao.Open();
            return conexao;
        }
        #endregion

        #region Obter todos os usuários
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try 
            { 
                using (var command = ConexaoBanco().CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM usuarios";
                    dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                    dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                    ConexaoBanco().Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Consultas sql
        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                using (var command = ConexaoBanco().CreateCommand())
                {
                    command.CommandText = sql;
                    dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                    dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                    ConexaoBanco().Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
