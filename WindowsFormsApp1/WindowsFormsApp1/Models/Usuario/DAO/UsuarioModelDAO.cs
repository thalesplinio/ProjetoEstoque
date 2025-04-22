using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Models.Usuario.DAO
{
    class UsuarioModelDAO
    {
        /// <summary>
        /// Método responsável por criar um usuário na base de dados.
        /// </summary>
        /// <param name="usuario">Necessário um Objeto como parâmetro</param>
        public static void InserirUsuario(UsuarioModel usuario)
        {
            if (ExisteUsername(usuario))
            {
                MessageBox.Show("Nome de usuário já em uso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cmd = Banco.ConexaoBanco().CreateCommand();
                cmd.CommandText = $@"
                    INSERT INTO usuarios 
                        (nome_completo_usuario, nome_usuario, email, telefone, senha, nivel_de_acesso, status_usuario, data_criacao_cadastro, data_atualizacao_cadastro)
                    VALUES 
                    (@nomeCompleto, @nomeDeUsuario, @email, @telefone, @senha, @nivelDeAcesso, @statusUsuario, @dataDeCriação, @dataDeAtualizacao)";
                cmd.Parameters.AddWithValue("@nomeCompleto", usuario.NomeCompleto);
                cmd.Parameters.AddWithValue("@nomeDeUsuario", usuario.NomeDeUsuario);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@nivelDeAcesso", (int)usuario.NivelDeAcesso);
                cmd.Parameters.AddWithValue("@statusUsuario", (int)usuario.StatusUsuario);
                cmd.Parameters.AddWithValue("@dataDeCriação", usuario.DataDeCadastro);
                cmd.Parameters.AddWithValue("@dataDeAtualizacao", usuario.DataDeAtualizacao);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir usuário - UsuarioController: {ex.Message}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
        }
        /// <summary>
        /// Método verifica se existe um usuário na base de dados com o mesmo nome
        /// se sim True, se não False
        /// </summary>
        /// <param name="usuario">Necessário um Objeto como parâmetro</param>
        /// <returns>boolean</returns>
        public static bool ExisteUsername(UsuarioModel usuario)
        {
            bool resultado;
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            var cmd = Banco.ConexaoBanco().CreateCommand();

            cmd.CommandText = $"SELECT nome_usuario FROM usuarios WHERE nome_usuario='{usuario.NomeDeUsuario}'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, Banco.ConexaoBanco());
            dataAdapter.Fill(dataTable);   // preenche com os dados o nosso dataTable

            // se encontrar resultado
            return resultado = dataTable.Rows.Count > 0 ? true : false;
        }
        /// <summary>
        /// Método responsável por atualizar os dados do usuário no banco de dados
        /// </summary>
        /// <param name="usuario">Necessário um Objeto como parâmetro</param>
        public static void AtualizarDadosUsuario(UsuarioModel usuario)
        {
            try
            {
                var cmd = Banco.ConexaoBanco().CreateCommand();
                cmd.CommandText = @"
                    UPDATE usuarios 
                    SET
                        nome_completo_usuario = @nomeCompleto,
                        nome_usuario = @nomeDeUsuario,
                        email = @email,
                        telefone = @telefone,
                        senha = @senha,
                        nivel_de_acesso = @nivelDeAcesso,
                        status_usuario = @statusUsuario,
                        data_criacao_cadastro = @dataDeCriação,
                        data_atualizacao_cadastro = @dataDeAtualizacao
                    WHERE
                        id_usuario = @id";
                cmd.Parameters.AddWithValue("@nomeCompleto", usuario.NomeCompleto);
                cmd.Parameters.AddWithValue("@nomeDeUsuario", usuario.NomeDeUsuario);
                cmd.Parameters.AddWithValue("@email", usuario.Senha);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@nivelDeAcesso", usuario.NivelDeAcesso);
                cmd.Parameters.AddWithValue("@statusUsuario", usuario.StatusUsuario);
                cmd.Parameters.AddWithValue("@dataDeCriação", usuario.DataDeCadastro);
                cmd.Parameters.AddWithValue("@dataDeAtualizacao", usuario.DataDeAtualizacao);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados do usuário atualizados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o usuaário - UsuarioModelDAO: {ex.Message}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
        }
        /// <summary>
        /// Método responsável por fazer a remoção de um usuário no banco de dados
        /// </summary>
        /// <param name="usuario">Necessário um Objeto como parâmetro</param>
        public static void RemoverUsuario(UsuarioModel usuario)
        {
            try
            {
                var cmd = Banco.ConexaoBanco().CreateCommand();
                cmd.CommandText = @"
                    DELETE FROM 
                        usuarios 
                    WHERE
                        id_usuario = @id";
                cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário removido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover o usuário - UsuarioModelDAO: {ex.Message}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.ConexaoBanco().Close();
            }
        }
    }
}
