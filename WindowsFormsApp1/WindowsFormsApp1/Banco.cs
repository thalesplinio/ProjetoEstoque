using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// --
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.Design;


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
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"SELECT * FROM usuarios";
                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Consultas sql / Usada no form_login
        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = sql;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Funções Form_AddUsuario / NovoUsuario - ExisteUserName

        #region NovoUsuario
        public static void NovoUsuario(Usuario usuario)
        {
            // verificando se o usuário existe
            if (ExisteUserName(usuario))
            {
                MessageBox.Show("Nome de usuário já existe!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // inserindo no banco
            try
            {
                DateTime data = DateTime.Now;
                var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = @"
                    INSERT INTO usuarios 
                        (
                            nome_completo, nome_usuario, email, telefone, 
                            senha, data_cadastro, usuario_ativo, nivel_acesso
                        ) 
                    VALUES 
                        (
                            @nome_completo, @nome_usuario, @email, @telefone, @senha, @data_cadastro, @usuario_ativo, @nivel_acesso
                        )";
                command.Parameters.AddWithValue("nome_completo", usuario.nome_completo);
                command.Parameters.AddWithValue("nome_usuario", usuario.nome_usuario);
                command.Parameters.AddWithValue("email", usuario.email);
                command.Parameters.AddWithValue("telefone", usuario.telefone);
                command.Parameters.AddWithValue("senha", usuario.senha);
                command.Parameters.AddWithValue("data_cadastro", dataFormatada);
                command.Parameters.AddWithValue("usuario_ativo", usuario.usuario_ativo);
                command.Parameters.AddWithValue("nivel_acesso", usuario.nivel_acesso);

                command.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch ( Exception ex) 
            {
                MessageBox.Show($"Não foi possivel cadastrar usuario ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        /// Rotinas gerais para verificar se já existe um usuário com o mesmo nome
        #region ExisteUserName
        public static bool ExisteUserName(Usuario usuario)
        {
            bool res;
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            var conexaoPropria = ConexaoBanco();
            var command  = conexaoPropria.CreateCommand();
            command.CommandText = "SELECT nome_usuario FROM usuarios WHERE nome_usuario='"+usuario.nome_usuario+"'";

            // verificando numero de linhas retornadas
            dataAdapter = new SQLiteDataAdapter(command.CommandText, conexaoPropria);
            dataAdapter.Fill(dataTable);
            
            if(dataTable.Rows.Count > 0)
            {
                // encontrou resultado
                res = true;
            }
            else
            {
                res = false;
            }
            conexaoPropria.Close();
            return res;
        }
        #endregion

        #endregion

        #region Funções Form_Todos_Usuarios / ObterDadosUsuarioBanco / ObterDadosParaEdicao / AtualizarUsuario

        #region ObterDadosUsuarioBanco
        public static DataTable ObterDadosUsuarioBanco()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        id_usuario as 'ID Usuário',
                        nome_completo as 'Nome completo',
                        nome_usuario as 'Nome de usuário',
                        email as 'E-Mail',
                        telefone as 'Telefone',
                        data_cadastro as 'Data Inserido',
                        usuario_ativo as 'Status do usuário',
                        nivel_acesso as 'Nível Acesso',
                        data_atualizacao as 'Data de Atualização'
                    FROM
                        usuarios";

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ObterDadosParaEdicao
        public static DataTable ObterDadosParaEdicao(string id)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        *
                    FROM
                        usuarios
                    WHERE
                        id_usuario="+id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region AtualizarUsuario
        public static void AtualizarUsuario(Usuario usuario)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    UPDATE 
                        usuarios
                    SET
                        nome_completo='"+usuario.nome_completo+"', nome_usuario= '"+usuario.nome_usuario+"', email = '"+usuario.email+"', telefone = '"+usuario.telefone+"', senha = '"+usuario.senha+"', usuario_ativo = '"+usuario.usuario_ativo+"', nivel_acesso = '"+usuario.nivel_acesso+"', data_atualizacao = '"+dataFormatada+"' WHERE id_usuario="+usuario.id_usuario;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                MessageBox.Show("Usuário atualizado com sucesso!", "Mensagem de atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi Atualizar usuario ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region DeletarUsuario
        public static void DeletarUsuario(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM usuarios WHERE id_usuario=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi Atualizar usuario ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion

        #region AdicionarStatus / ObterStatus / ExcluirStatus / ObterDadosStatusParaEdicao
        public static void AdicionarStatus(Status status)
        {
            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = @"
                    INSERT INTO status_usuario (nome_status) VALUES (@nome_status)";
                command.Parameters.AddWithValue("nome_status", status.nome_status);

                command.ExecuteNonQuery();
                MessageBox.Show("Status registrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar status ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static DataTable ObterStatus()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        id_status as 'ID status',
                        nome_status as 'Nome do status'
                    FROM
                        status_usuario";

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ObterDadosStatusParaEdicao(string id)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        *
                    FROM
                        status_usuario
                    WHERE
                        id_status=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                dataAdapter.Fill(dataTable);    // preenchendo com as informações da consulta
                conexaoPropria.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ExcluirStatus(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM status_usuario WHERE id_status=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi removes o status ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
