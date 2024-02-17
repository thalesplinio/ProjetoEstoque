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
    public partial class Form_Main : Form
    {
        #region Set Colors Butons
        public Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
        public Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
        #endregion
        public Form_Main()
        {
            InitializeComponent();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();

            DateTime date = DateTime.Now;
            lb_date.Text = $"{date:D} {date:T}";
        }

        #region Buttons Hover Color
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_inicio.BackColor = corVerdePadrao;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_inicio.BackColor = corAzulPadrao;
        }

        private void btn_cadastrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = corVerdePadrao;
        }

        private void btn_cadastrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = corAzulPadrao;
        }

        private void btn_retirar_MouseEnter(object sender, EventArgs e)
        {
            btn_retirar.BackColor = corVerdePadrao;
        }

        private void btn_retirar_MouseLeave(object sender, EventArgs e)
        {
            btn_retirar.BackColor = corAzulPadrao;
        }

        private void btn_listar_MouseEnter(object sender, EventArgs e)
        {
            btn_listar.BackColor = corVerdePadrao;
        }

        private void btn_listar_MouseLeave(object sender, EventArgs e)
        {
            btn_listar.BackColor = corAzulPadrao;
        }

        private void btn_gerenciar_MouseEnter(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = corVerdePadrao;
        }

        private void btn_gerenciar_MouseLeave(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = corAzulPadrao;
        }
        #endregion
    }
}
