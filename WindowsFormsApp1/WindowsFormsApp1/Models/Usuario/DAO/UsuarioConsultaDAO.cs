using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Models.Usuario.DAO
{
    class UsuarioConsultaDAO
    {
        public static DataTable VerificaNomeESenhaDoUsuario(String nome, String senha)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            try { 
                var cmd = ConnectionBank.GetMyConnection().CreateCommand();
                cmd.CommandText = @"
                        SELECT id_usuario, nome_usuario, nivel_de_acesso, status_usuario FROM usuarios 
                        WHERE 
                            nome_usuario=@nome AND senha=@senha AND status_usuario=@status";
                cmd.Parameters.AddWithValue("@nome", nome.ToString());
                cmd.Parameters.AddWithValue("@senha", senha.ToString());
                cmd.Parameters.AddWithValue("@status", 1);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar login: " + ex.Message);
            }
            return dt;
        }
        public static DataTable ConsultaUsuario(string sqlComand)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConnectionBank.GetMyConnection();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sqlComand;  // cria o comando
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);   // executa o comando
                dataAdapter.Fill(dataTable);    // preenche o datatable com essas informações
                vcon.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
