using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class UsuarioModel
    {
        public Int32 id_usuario {  get; set; }
        public string nome_completo { get; set; }
        public string nome_usuario { get; set; }
        public string email {  get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public DateTime data_cadastro { get; set; }
        public string usuario_ativo { get; set; }
        public Int32 nivel_acesso { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
