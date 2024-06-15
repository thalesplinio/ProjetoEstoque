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
    public partial class Form_Categoria : Form
    {
        public Form_Categoria()
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
        private void btn_addCategoria_MouseEnter(object sender, EventArgs e)
        {
            btn_addCategoria.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_addCategoria_MouseLeave(object sender, EventArgs e)
        {
            btn_addCategoria.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_removeCategoria_MouseEnter(object sender, EventArgs e)
        {
            btn_removeCategoria.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_removeCategoria_MouseLeave(object sender, EventArgs e)
        {
            btn_removeCategoria.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion
        private void Form_Categoria_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewCategoria.DataSource = Banco.ObterCategoria();
            kryptonDataGridViewCategoria.Sort(kryptonDataGridViewCategoria.Columns["ID Categoria"], ListSortDirection.Descending);
            kryptonDataGridViewCategoria.Columns[0].Width = 100;
            kryptonDataGridViewCategoria.Columns[1].Width = 315;
        }
        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.nome_categoria = tb_nomeCategoria.Text;
            Banco.AdicionarCategoria(categoria);
            tb_nomeCategoria.Clear();
            kryptonDataGridViewCategoria.DataSource = Banco.ObterCategoria();
            kryptonDataGridViewCategoria.Sort(kryptonDataGridViewCategoria.Columns["ID Categoria"], ListSortDirection.Descending);
        }

        private void kryptonDataGridViewCategoria_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string idStatus = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosStatusParaEdicaoCategoria(idStatus);

                tb_idCategoriaRemove.Text = dataTable.Rows[0].Field<Int64>("id_categoria").ToString();
                tb_nomeCategoriaRemove.Text = dataTable.Rows[0].Field<string>("nome_categoria").ToString();
            }
        }

        private void btn_removeCategoria_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir esta categoria de produto?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Banco.ExcluirCategoria(tb_idCategoriaRemove.Text);
                kryptonDataGridViewCategoria.DataSource = Banco.ObterCategoria();
                kryptonDataGridViewCategoria.Sort(kryptonDataGridViewCategoria.Columns["ID Categoria"], ListSortDirection.Descending);
            }
        }


    }
}
