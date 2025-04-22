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

        public static SQLiteConnection GetConnection(string dataBasePath)
        {
            if(_connection == null)
            {
                _connection = new SQLiteConnection($"Data Source={dataBasePath};Version=3");
                _connection.Open();
            }
            return _connection;
        }

        public static void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }

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
