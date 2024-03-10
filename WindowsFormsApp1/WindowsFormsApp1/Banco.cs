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
using System.Data.Entity;


namespace WindowsFormsApp1
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        #region Conexao banco
        public static SQLiteConnection ConexaoBanco()
        {

            string caminhoBancoDeDados = $@"{Globais.caminhoBanco}{Globais.nomeBanco}";
            conexao = new SQLiteConnection($@"Data Source={caminhoBancoDeDados}");
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

        /// Rotinas gerais para verificar se já existe um usuário com o mesmo nome
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

        #region Funções Form_Todos_Usuarios / ObterDadosUsuarioBanco / ObterDadosParaEdicao / AtualizarUsuario

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

                command.CommandText = @"INSERT INTO status_usuario (nome_status) VALUES (@nome_status)";
                command.Parameters.AddWithValue("nome_status", status.nome_status);

                command.ExecuteNonQuery();
                MessageBox.Show("Status de usuário registrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar status do usuário ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Não foi remover o status ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region SESSAO DE PRODUTOS

        #region Sessão de Categorias
        public static void AdicionarCategoria(Categoria categoria)
        {
            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = $"INSERT INTO categoria_produto (nome_categoria) VALUES (@nome_categoria)";
                command.Parameters.AddWithValue("nome_categoria", categoria.nome_categoria);

                command.ExecuteNonQuery();
                MessageBox.Show("Categoria de produto registrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar a categoria ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static DataTable ObterCategoria()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        id_categoria as 'ID Categoria',
                        nome_categoria as 'Nome da categoria'
                    FROM
                        categoria_produto";

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
        public static DataTable ObterDadosStatusParaEdicaoCategoria(string id)
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
                        categoria_produto
                    WHERE
                        id_categoria=" + id;

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
        public static void ExcluirCategoria(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM categoria_produto WHERE id_categoria=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi removes a categoria ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Sessão de Tipos
        public static void AdicionarTipo(Tipo tipo)
        {
            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = $"INSERT INTO tipo_produto (nome_tipo) VALUES (@nome_tipo)";
                command.Parameters.AddWithValue("nome_tipo", tipo.nome_tipo);

                command.ExecuteNonQuery();
                MessageBox.Show("Tipo de produto registrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar o tipo do produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static DataTable ObterTipo()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        id_tipo as 'ID Tipo',
                        nome_tipo as 'Nome do Tipo'
                    FROM
                        tipo_produto";

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
        public static DataTable ObterDadosStatusParaEdicaoTipo(string id)
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
                        tipo_produto
                    WHERE
                        id_tipo=" + id;

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
        public static void ExcluirTipo(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM tipo_produto WHERE id_tipo=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi remover o tipo do produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion

        #region SESSAO FORNECEDOR
        public static bool ExisteFornecedor(Fornecedor fornecedor)
        {
            bool res;
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            var conexaoPropria = ConexaoBanco();
            var command = conexaoPropria.CreateCommand();
            command.CommandText = "SELECT nome FROM fornecedor_produto WHERE nome='" + fornecedor.nome + "'";

            // verificando numero de linhas retornadas
            dataAdapter = new SQLiteDataAdapter(command.CommandText, conexaoPropria);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
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
        public static void NovoFornecedor(Fornecedor fornecedor)
        {
            if (ExisteFornecedor(fornecedor))
            {
                MessageBox.Show(
                    "Nome do fornecedor já existe no sistema", 
                    "Mensagem", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            try
            {
                DateTime data = DateTime.Now;
                var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = @"
                    INSERT INTO fornecedor_produto 
                        (nome, cnpj, endereco, telefone, email, data_criacao_cadastro) 
                    VALUES 
                        (@nome_tipo, @cnpj, @endereco, @telefone, @email, @data_criacao_cadastro)";
                command.Parameters.AddWithValue("nome_tipo", fornecedor.nome);
                command.Parameters.AddWithValue("cnpj", fornecedor.cnpj);
                command.Parameters.AddWithValue("endereco", fornecedor.endereco);
                command.Parameters.AddWithValue("telefone", fornecedor.telefone);
                command.Parameters.AddWithValue("email", fornecedor.email);
                command.Parameters.AddWithValue("data_criacao_cadastro", dataFormatada);
                command.ExecuteNonQuery();

                MessageBox.Show("Fornecedor registrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar este fornecedor ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void AtualizarFornecedor(Fornecedor fornecedor)
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
                        fornecedor_produto
                    SET
                        nome='" + fornecedor.nome + "', cnpj= '" + fornecedor.cnpj + "', endereco = '" + fornecedor.endereco + "', telefone = '" + fornecedor.telefone + "', email = '" + fornecedor.email + "', data_atualizacao_cadastro = '" + dataFormatada + "' WHERE id_fornecedor=" + fornecedor.id_fornecedor;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                MessageBox.Show("Fornecedor atualizado com sucesso!", "Mensagem de atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi Atualizar o fornecedor ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static DataTable ObterFornecedor()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        id_fornecedor as 'ID Fornecedor',
                        nome as 'Nome do Fornecedor',
                        cnpj as 'CNPJ',
                        endereco as 'Endereço',
                        telefone as 'Telefone',
                        email as 'E-Mail',
                        data_criacao_cadastro as 'Data de criação',
                        data_atualizacao_cadastro as 'Data atualização'
                    FROM
                        fornecedor_produto";

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
        public static DataTable ObterDadosStatusParaEdicaoFornecedor(string id)
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
                        fornecedor_produto
                    WHERE
                        id_fornecedor=" + id;

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
        public static void ExcluirFornecedor(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM fornecedor_produto WHERE id_fornecedor=" + id;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi remover o tipo do produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region CADASTRO DE PRODUTOS
        public static void AdicionarProduto(Produtos produtos)
        {
            try
            {
                DateTime data = DateTime.Now;
                var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = @"
                    INSERT INTO produtos 
                        (
                            id_usuario, id_fornecedor, nome, marca, 
                            quantidade, quantidade_minima, id_categoria, id_tipo_produto, 
                            descricao, data_criacao, image
                        ) 
                    VALUES 
                        (
                            @id_usuario, @id_fornecedor, @nome, @marca, @quantidade, @quantidade_minima, @id_categoria, @id_tipo_produto, @descricao, @data_criacao , @image
                        )";
                command.Parameters.AddWithValue("id_usuario", produtos.id_usuario);
                command.Parameters.AddWithValue("id_fornecedor", produtos.id_fornecedor);
                command.Parameters.AddWithValue("nome", produtos.nome);
                command.Parameters.AddWithValue("marca", produtos.marca);
                command.Parameters.AddWithValue("quantidade", produtos.quantidade);
                command.Parameters.AddWithValue("quantidade_minima", produtos.quantidade_minima);
                command.Parameters.AddWithValue("id_categoria", produtos.id_categoria);
                command.Parameters.AddWithValue("id_tipo_produto", produtos.id_tipo_produto);
                command.Parameters.AddWithValue("descricao", produtos.descricao);
                command.Parameters.AddWithValue("data_criacao", dataFormatada);
                command.Parameters.AddWithValue("image", produtos.image);


                command.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel cadastrar este produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static DataTable ObterProdutos()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT
                        prod.id_produto as 'ID Produto',
                        fprod.nome as 'Fornecedor',
                        prod.nome as 'Nome Produto',
                        prod.marca as 'Marca Produto',
                        prod.quantidade as 'Quantidade',
                        prod.quantidade_minima as 'Qtd. Mínima',
                        cProd.nome_categoria as 'Categoria',
                        tProd.nome_tipo as 'Tipo de Produto',
                        prod.descricao as 'Descrição',
                        prod.data_criacao as 'Data Cadastro',
                        prod.data_atualizacao as 'Data Atualização'
                    FROM
                        produtos as prod
                    INNER JOIN
                        fornecedor_produto as fprod ON fprod.id_fornecedor = prod.id_fornecedor
                    INNER JOIN
                        categoria_produto as cProd ON cProd.id_categoria = prod.id_categoria
                    INNER JOIN
                        tipo_produto as tProd on tProd.id_tipo = prod.id_tipo_produto";

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

        #region LISTAR PRODUTOS
        public static DataTable ObterProdutosParaListar()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT
                        prod.id_produto as 'ID Produto',
                        fprod.nome as 'Fornecedor',
                        prod.nome as 'Nome Produto',
                        prod.marca as 'Marca Produto',
                        prod.quantidade as 'Quantidade',
                        prod.quantidade_minima as 'Qtd. Mínima',
                        cProd.nome_categoria as 'Categoria',
                        tProd.nome_tipo as 'Tipo de Produto',
                        prod.descricao as 'Descrição',
                        prod.data_criacao as 'Data Cadastro',
                        prod.data_atualizacao as 'Data Atualização'
                    FROM
                        produtos as prod
                    INNER JOIN
                        fornecedor_produto as fprod ON fprod.id_fornecedor = prod.id_fornecedor
                    INNER JOIN
                        categoria_produto as cProd ON cProd.id_categoria = prod.id_categoria
                    INNER JOIN
                        tipo_produto as tProd on tProd.id_tipo = prod.id_tipo_produto";

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
        public static DataTable ObterDadosParaVisualizarProdutos(string id)
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
                        produtos
                    WHERE
                        id_produto=" + id;

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
        public static DataTable ObterQuantidade()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"SELECT SUM(quantidade) FROM produtos";

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

        #region RETIRAR PRODUTOS
        public static DataTable ObterProdutosParaRetirar(Produtos produto)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT
                        prod.id_produto as 'ID Produto',
                        fprod.nome as 'Fornecedor',
                        prod.nome as 'Nome Produto',
                        prod.marca as 'Marca Produto',
                        prod.quantidade as 'Quantidade',
                        prod.quantidade_minima as 'Qtd. Mínima',
                        cProd.nome_categoria as 'Categoria',
                        tProd.nome_tipo as 'Tipo de Produto',
                        prod.descricao as 'Descrição',
                        prod.data_criacao as 'Data Cadastro',
                        prod.data_atualizacao as 'Data Atualização'
                    FROM
                        produtos as prod
                    INNER JOIN
                        fornecedor_produto as fprod ON fprod.id_fornecedor = prod.id_fornecedor
                    INNER JOIN
                        categoria_produto as cProd ON cProd.id_categoria = prod.id_categoria
                    INNER JOIN
                        tipo_produto as tProd on tProd.id_tipo = prod.id_tipo_produto";

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

        public static void AtualizarProdutoEstoque(Produtos produtos, int quantidade)
        {
            try
            {
                DateTime data = DateTime.Now;
                var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();

                command.CommandText = @"
                    UPDATE produtos 
                        SET
                            quantidade = @quantidade
                        WHERE 
                            id_produto = @id_produto";


                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@id_produto", produtos.id_produto);

                command.ExecuteNonQuery();
                MessageBox.Show("Produto foi retirado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não possível retirar o produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region GERENCIAR ESTOQUE
        public static DataTable ObterProdutosParaGerenciar()
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"
                    SELECT
                        prod.id_produto as 'ID Produto',
                        fprod.nome as 'Fornecedor',
                        prod.nome as 'Nome Produto',
                        prod.marca as 'Marca Produto',
                        prod.quantidade as 'Quantidade',
                        prod.quantidade_minima as 'Qtd. Mínima',
                        cProd.nome_categoria as 'Categoria',
                        tProd.nome_tipo as 'Tipo de Produto',
                        prod.descricao as 'Descrição',
                        prod.data_criacao as 'Data Cadastro',
                        prod.data_atualizacao as 'Data Atualização'
                    FROM
                        produtos as prod
                    INNER JOIN
                        fornecedor_produto as fprod ON fprod.id_fornecedor = prod.id_fornecedor
                    INNER JOIN
                        categoria_produto as cProd ON cProd.id_categoria = prod.id_categoria
                    INNER JOIN
                        tipo_produto as tProd on tProd.id_tipo = prod.id_tipo_produto";

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
        public static void DeletarGerenciaProduto(string id)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"DELETE FROM produtos WHERE id_produto=" + id;

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
        public static void AtualizarGerenciaProdutos(Produtos produtos)
        {
            DateTime data = DateTime.Now;
            var dataFormatada = $"{data:yyyy-MM-dd HH:mm:ss}";

            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = @"UPDATE produtos SET id_fornecedor='" + produtos.id_fornecedor + "', nome='" + produtos.nome + "', marca='" + produtos.marca + "', quantidade='" + produtos.quantidade + "', quantidade_minima='" + produtos.quantidade_minima + "', id_categoria='" + produtos.id_categoria + "', id_tipo_produto='" + produtos.id_tipo_produto + "', descricao='" + produtos.descricao + "', image='" + produtos.image + "', data_atualizacao='"+dataFormatada+"' WHERE id_produto=" + produtos.id_produto;

                dataAdapter = new SQLiteDataAdapter(command.CommandText, ConexaoBanco());
                command.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!", "Mensagem de atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexaoPropria.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Não foi possivel atualizar o produto ERRO - {ex}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static DataTable BuscaNomeProduto(string parametro)
        {
            SQLiteDataAdapter dataAdapter = null;   // Consulta - comando sql, conexao banco
            DataTable dataTable = new DataTable();  // preenche com as informações da consulta

            try
            {
                var conexaoPropria = ConexaoBanco();
                var command = conexaoPropria.CreateCommand();
                command.CommandText = $@"
                    SELECT
                        prod.id_produto as 'ID Produto',
                        fprod.nome as 'Fornecedor',
                        prod.nome as 'Nome Produto',
                        prod.marca as 'Marca Produto',
                        prod.quantidade as 'Quantidade',
                        prod.quantidade_minima as 'Qtd. Mínima',
                        cProd.nome_categoria as 'Categoria',
                        tProd.nome_tipo as 'Tipo de Produto',
                        prod.descricao as 'Descrição',
                        prod.data_criacao as 'Data Cadastro',
                        prod.data_atualizacao as 'Data Atualização'
                    FROM
                        produtos as prod
                    INNER JOIN
                        fornecedor_produto as fprod ON fprod.id_fornecedor = prod.id_fornecedor
                    INNER JOIN
                        categoria_produto as cProd ON cProd.id_categoria = prod.id_categoria
                    INNER JOIN
                        tipo_produto as tProd on tProd.id_tipo = prod.id_tipo_produto
                    WHERE prod.nome LIKE '%{parametro}%'";

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
    }
}
