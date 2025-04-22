using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Usuario.Enum;

namespace WindowsFormsApp1.Data
{
    class CreateDatabaseInitialData
    {
        public static void InsertInitialAdminUser(SQLiteConnection connection)
        {
            string Nome = "Administrador";
            string NomeUsuario = "admin";
            string Senha = "123";
            int NivelDeAcesso = (int)EnumNivelDeAcesso.Administrador;
            int Status = (int)EnumStatusUsuario.Ativo;
            DateTime Data = DateTime.Now;

            var sqlQuery = @"
                INSERT INTO 
                    usuarios 
                    (nome_completo_usuario, nome_usuario, email, telefone, senha, nivel_de_acesso, 
                        status_usuario, data_criacao_cadastro, data_atualizacao_cadastro)
                VALUES
                    (@nomeCompleto, @nomeUsuario, @email, @telefone, @senha, @nivelDeAcesso, 
                        @statusUsuario, @dataCriacaoCadastro, @dataAtualizacaoCadastro);";
            using (var command = new SQLiteCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@nomeCompleto", Nome);
                command.Parameters.AddWithValue("@nomeUsuario", NomeUsuario);
                command.Parameters.AddWithValue("@email", "email_adm@email.com");
                command.Parameters.AddWithValue("@telefone", null);
                command.Parameters.AddWithValue("@senha", Senha);
                command.Parameters.AddWithValue("@nivelDeAcesso", NivelDeAcesso);
                command.Parameters.AddWithValue("@statusUsuario", Status);
                command.Parameters.AddWithValue("@dataCriacaoCadastro", Data);
                command.Parameters.AddWithValue("@dataAtualizacaoCadastro", null);
                command.ExecuteNonQuery();
            }
        }
    }
}
