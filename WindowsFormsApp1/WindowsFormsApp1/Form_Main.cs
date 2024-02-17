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
        DataTable dataTable = null;

        public Form_Main()
        {
            InitializeComponent();
            Form_Login form_Login = new Form_Login(this);
            form_Login.ShowDialog();

            DateTime date = DateTime.Now;
            lb_date.Text = $"{date:D} {date:T}";
        }

        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            public static Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
        }
        #endregion

        #region Buttons Hover Color
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_inicio.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_inicio.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_cadastrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_cadastrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastrar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_retirar_MouseEnter(object sender, EventArgs e)
        {
            btn_retirar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_retirar_MouseLeave(object sender, EventArgs e)
        {
            btn_retirar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_listar_MouseEnter(object sender, EventArgs e)
        {
            btn_listar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_listar_MouseLeave(object sender, EventArgs e)
        {
            btn_listar.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_gerenciar_MouseEnter(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_gerenciar_MouseLeave(object sender, EventArgs e)
        {
            btn_gerenciar.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void tarocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login(this);
            form_Login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // usuario deslogado
            lb_UserLogado.Text = "...";
            Globais.nivel = 0;
            Globais.logado = false;
            this.Close();

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente fechar a aplicação?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
                // usuario deslogado
                lb_UserLogado.Text = "...";
                Globais.nivel = 0;
                Globais.logado = false;
                this.Close();
            }
        }
    }
}
