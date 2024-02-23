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
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Categoria form_Categoria = new Form_Categoria();
            form_Categoria.ShowDialog();
        }

        private void btn_addTipo_Click(object sender, EventArgs e)
        {
            Form_Tipo form_Tipo = new Form_Tipo();
            form_Tipo.ShowDialog();
        }
    }
}
