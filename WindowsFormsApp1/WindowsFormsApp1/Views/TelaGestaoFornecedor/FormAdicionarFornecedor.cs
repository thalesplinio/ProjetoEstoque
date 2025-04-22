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
    public partial class FormAdicionarFornecedor : Form
    {
        public FormAdicionarFornecedor()
        {
            InitializeComponent();
        }
        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            public static Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D

            public static Color corControl = Color.FromArgb(240, 240, 240);
            public static Color corControlLight = Color.FromArgb(227, 227, 227);
        }
        #endregion

        #region Buttons Hover Color
        private void btn_verTodosFornecedores_MouseEnter(object sender, EventArgs e)
        {
            btn_verTodosFornecedores.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_verTodosFornecedores_MouseLeave(object sender, EventArgs e)
        {
            btn_verTodosFornecedores.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_SalvarFornecedor_MouseEnter(object sender, EventArgs e)
        {
            btn_SalvarFornecedor.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_SalvarFornecedor_MouseLeave(object sender, EventArgs e)
        {
            btn_SalvarFornecedor.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancelar.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion
        private void LimpaCampos()
        {
            tb_nomeFornecedor.Clear();
            tb_cnpjFornecedor.Clear();
            tb_enderecoFornecedor.Clear();
            mtb_telefoneFornecedor.Clear();
            tb_emailFornecedor.Clear();
        }
        private void btn_SalvarFornecedor_Click(object sender, EventArgs e)
        {
            FornecedorModel fornecedor = new FornecedorModel();

            fornecedor.nome = tb_nomeFornecedor.Text;
            fornecedor.cnpj = tb_cnpjFornecedor.Text;
            fornecedor.endereco = tb_enderecoFornecedor.Text;
            fornecedor.telefone = mtb_telefoneFornecedor.Text;
            fornecedor.email = tb_emailFornecedor.Text;

            Banco.NovoFornecedor(fornecedor);
            LimpaCampos();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_verTodosFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores form_Fornecedores = new FormFornecedores();
            form_Fornecedores.ShowDialog();
        }
    }
}
