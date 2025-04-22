using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Usuario.DAO;

namespace WindowsFormsApp1.Controllers
{
    class UsuarioController
    {
        public static void NovoUsuario(UsuarioModel usuario)
        {
            if (UsuarioModelDAO.ExisteUsername(usuario))
            {
                MessageBox.Show("Nome de usuário já em uso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UsuarioModelDAO.InserirUsuario(usuario);
        }
        public static DataTable obterLoginUsuario(String nome, String senha)
        {
            return UsuarioConsultaDAO.VerificaNomeESenhaDoUsuario(nome, senha);
        }
        
    }
}
