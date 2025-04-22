using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class StatusUsuarioModel
    {
        public Int32 id_status { get; set; }
        public string nome_status { get; set; }

        /*
            Enum
                Ativo = 1,
                Inativo = 2,
                Bloqueado = 3,
                Suspenso = 4

        Ativo: Pode acessar o sistema normalmente.
        Inativo: Conta desativada temporariamente.
        Bloqueado: Acesso suspenso por erro ou medida administrativa.
        Suspenso: Situação temporária por questões específicas (como falta de pagamento ou análise de segurança).
         */

        /*
            public enum NivelAcesso
{
            Administrador = 0,
            Gerente = 1,
            Operador = 2,
            Visualizador = 3

        Administrador: Controle total sobre tudo.
        Gerente: Pode cadastrar/editar produtos, usuários e visualizar relatórios.
        Operador: Pode registrar vendas, entradas, consultar estoque.
        Visualizador: Somente leitura (bom pra auditorias ou consulta externa).
         */
    }
}
