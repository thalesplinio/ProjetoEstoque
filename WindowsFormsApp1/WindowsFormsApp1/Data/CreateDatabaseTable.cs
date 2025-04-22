using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    class CreateDatabaseTable
    {
        public static void CreateInitialDatabase(SQLiteConnection connection)
        {
            var commandCreateTable = @"
                    CREATE TABLE IF NOT EXISTS fornecedor_produto (
						""id_fornecedor""				INTEGER PRIMARY KEY AUTOINCREMENT,
						""nome""						VARCHAR(255) NOT NULL,
						""cnpj""						VARCHAR(15) NOT NULL,
						""endereco""					VARCHAR(255) NOT NULL,
						""telefone""					VARCHAR(15) NOT NULL,
						""email""						VARCHAR(255) NOT NULL,
						""data_criacao_cadastro""		DATETIME,
						""data_atualizacao_cadastro""	DATETIME
                    );    
                    CREATE TABLE IF NOT EXISTS categoria_produto (
	                    ""id_categoria""				INTEGER PRIMARY KEY AUTOINCREMENT,
	                    ""nome""						VARCHAR(255) NOT NULL
                    );
                    CREATE TABLE IF NOT EXISTS tipo_produto (
	                    ""id_tipo""						INTEGER  PRIMARY KEY AUTOINCREMENT,
	                    ""nome""						VARCHAR(255) NOT NULL
                    );
					CREATE TABLE IF NOT EXISTS usuarios (
						""id_usuario""					INTEGER  PRIMARY KEY AUTOINCREMENT,
						""nome_completo_usuario""		VARCHAR(255) NOT NULL,
						""nome_usuario""				VARCHAR(255) NOT NULL UNIQUE,
						""email""						VARCHAR(255) NOT NULL,
						""telefone""					VARCHAR(14),
						""senha""						VARCHAR(30) NOT NULL,
						""nivel_de_acesso""				INTEGER NOT NULL,	/* ""ENUM - NIVEL_DE_ACESSO"" */
						""status_usuario""				INTEGER NOT NULL,	/* ""ENUM - STATUS_USUARIO""  */
						""data_criacao_cadastro""		DATETIME,
						""data_atualizacao_cadastro""	DATETIME
					);
					CREATE TABLE IF NOT EXISTS produtos (
						""id_produto""					INTEGER PRIMARY KEY AUTOINCREMENT,
						""id_usuario""					INTEGER,
						""id_fornecedor""				INTEGER,
						""nome""						VARCHAR(255),
						""marca""						VARCHAR(100),
						""id_categoria""				INTEGER,
						""descricao""					VARCHAR(255),
						""quantidade""					INTEGER,
						""quantidade_minima""			INTEGER,
						""id_tipo_produto""				INTEGER,
						""imagem_produto""				VARCHAR(255),
						""data_criacao_cadastro""		DATETIME,
						""data_atualizacao_cadastro""	DATETIME,

						FOREIGN KEY(""id_usuario"") REFERENCES ""usuarios""(""id_usuario""),
						FOREIGN KEY(""id_fornecedor"") REFERENCES ""fornecedor_produto""(""id_fornecedor""),
						FOREIGN KEY(""id_categoria"") REFERENCES ""categoria_produto""(""id_categoria""),
						FOREIGN KEY(""id_tipo_produto"") REFERENCES ""tipo_produto""(""id_tipo"")
					);";
			using (var command = new SQLiteCommand(commandCreateTable, connection))
			{
				command.ExecuteNonQuery();
			}
        }
    }
}
