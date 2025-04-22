using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Usuario.Enum;

namespace WindowsFormsApp1
{
    internal class UsuarioModel
    {
        public Int32 IdUsuario {  get; set; }
        public string NomeCompleto { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email {  get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public EnumNivelDeAcesso NivelDeAcesso { get; set; }
        public EnumStatusUsuario StatusUsuario { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public DateTime DataDeAtualizacao { get; set; }
    }
}
