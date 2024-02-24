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
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
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
        private void btn_limpaCampos_MouseEnter(object sender, EventArgs e)
        {
            btn_limpaCampos.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_limpaCampos_MouseLeave(object sender, EventArgs e)
        {
            btn_limpaCampos.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_insereProduto_MouseEnter(object sender, EventArgs e)
        {
            btn_insereProduto.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_insereProduto_MouseLeave(object sender, EventArgs e)
        {
            btn_insereProduto.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void Form_Cadastro_Load(object sender, EventArgs e)
        {
            string vQueryFornecedor = @"SELECT nome FROM fornecedor_produto";
            cb_Fornecedor.Items.Clear();
            cb_Fornecedor.DataSource = Banco.Consulta(vQueryFornecedor);
            cb_Fornecedor.DisplayMember = "nome";
            cb_Fornecedor.ValueMember = "nome";

            string vQueryCategoria = @"SELECT nome_categoria FROM categoria_produto";
            cb_categoria.Items.Clear();
            cb_categoria.DataSource = Banco.Consulta(vQueryCategoria);
            cb_categoria.DisplayMember = "nome_categoria";
            cb_categoria.ValueMember = "nome_categoria";

            string vQueryTipo = @"SELECT nome_tipo FROM tipo_produto";
            cb_tipo.Items.Clear();
            cb_tipo.DataSource = Banco.Consulta(vQueryTipo);
            cb_tipo.DisplayMember = "nome_tipo";
            cb_tipo.ValueMember = "nome_tipo";
        }


    }
}
