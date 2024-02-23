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
    public partial class Form_Fornecedores : Form
    {
        public Form_Fornecedores()
        {
            InitializeComponent();
        }

        private void btn_SalvarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.nome = tb_nomeFornecedor.Text;
            fornecedor.cnpj = tb_cnpjFornecedor.Text;
            fornecedor.endereco = tb_enderecoFornecedor.Text;
            fornecedor.telefone = mtb_telefoneFornecedor.Text;
            fornecedor.email = tb_emailFornecedor.Text;

            Banco.NovoFornecedor(fornecedor);
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            tb_nomeFornecedor.Clear();
            tb_cnpjFornecedor.Clear();
            tb_enderecoFornecedor.Clear();
            mtb_telefoneFornecedor.Clear();
            tb_emailFornecedor.Clear();
        }
    }
}
