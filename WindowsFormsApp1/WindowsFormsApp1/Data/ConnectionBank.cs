using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Data
{
    class ConnectionBank
    {
        private static SQLiteConnection _connection;
        private static string MyDatabasePathConnection = $"Data Source={Globais.caminhoBancoTESTE}{Globais.nomeBancoTESTE};Version=3";

        /// <summary>
        /// Cria conexão com o banco de dados, mas é necessário passar o caminho do banco
        /// </summary>
        /// <param name="dataBasePath">Passar o local do banco de dados</param>
        /// <returns>Conexão aberta</returns>
        public static SQLiteConnection GetConnection(string dataBasePath)
        {
            if(_connection == null)
            {
                _connection = new SQLiteConnection($"Data Source={dataBasePath};Version=3");
                _connection.Open();
            }
            return _connection;
        }
        /// <summary>
        /// Cria a conexão com banco sem precisar do caminho da base de dados
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SQLiteConnection GetMyConnection()
        {
            if (_connection == null)
            {
                _connection = new SQLiteConnection(MyDatabasePathConnection);
                _connection.Open();
            }
            return _connection;
        }
        /// <summary>
        /// Fecha a conexão do banco de dados
        /// </summary>
        public static void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
        /// <summary>
        /// Responsável por criar a base de dados e o usuário admin
        /// Primeiro usuário do sistema com privilégios.
        /// </summary>
        /// <param name="dataBasePath">Passar o local do banco de dados</param>
        public static void CreateDataBasesIfNotExists(string dataBasePath)
        {
            if (!File.Exists(dataBasePath))
            {
                SQLiteConnection.CreateFile(dataBasePath);

                using (var connection = GetConnection(dataBasePath))
                {
                    try
                    {
                        CreateDatabaseTable.CreateInitialDatabase(connection);
                        CreateDatabaseInitialData.InsertInitialAdminUser(connection);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Não foi possível criar a tabela inicial do programa - {e.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
