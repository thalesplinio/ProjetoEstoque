using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Todos_Usuarios : Form
    {
        public Form_Todos_Usuarios()
        {
            InitializeComponent();
            lb_detalhesStatus.Text = "A = Ativo,\nB = Bloqueado,\nD = Desligado";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            tb_nomeCompleto.Clear();
            tb_nomeUsuario.Clear();
            tb_email.Clear();
            mtb_telefone.Clear();
            cb_statusUsuario.Text = "";
            nud_nivelAcesso.Value = 0;
            tb_nomeCompleto.Focus();
        }
    }
}
