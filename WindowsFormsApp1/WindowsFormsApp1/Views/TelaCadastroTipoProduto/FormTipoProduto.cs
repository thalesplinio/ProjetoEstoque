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
    public partial class FormTipoProduto : Form
    {
        public FormTipoProduto()
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
        private void btn_addTipo_MouseEnter(object sender, EventArgs e)
        {
           btn_addTipo.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_addTipo_MouseLeave(object sender, EventArgs e)
        {
            btn_addTipo.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_removeTipo_MouseEnter(object sender, EventArgs e)
        {
            btn_removeTipo.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_removeTipo_MouseLeave(object sender, EventArgs e)
        {
            btn_removeTipo.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void Form_Tipo_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewTipo.DataSource = Banco.ObterTipo();
            kryptonDataGridViewTipo.Sort(kryptonDataGridViewTipo.Columns["ID Tipo"], ListSortDirection.Descending);
            kryptonDataGridViewTipo.Columns[0].Width = 100;
            kryptonDataGridViewTipo.Columns[1].Width = 315;
        }

        private void btn_addTipo_Click(object sender, EventArgs e)
        {
            TipoProdutoModel tipo = new TipoProdutoModel();
            tipo.nome_tipo = tb_nomeTipo.Text;
            Banco.AdicionarTipo(tipo);
            tb_nomeTipo.Clear();
            kryptonDataGridViewTipo.DataSource = Banco.ObterTipo();
            kryptonDataGridViewTipo.Sort(kryptonDataGridViewTipo.Columns["ID Tipo"], ListSortDirection.Descending);
        }

        private void kryptonDataGridViewTipo_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string idStatus = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosStatusParaEdicaoTipo(idStatus);

                tb_idTipoRemove.Text = dataTable.Rows[0].Field<Int64>("id_tipo").ToString();
                tb_nomeTipoRemove.Text = dataTable.Rows[0].Field<string>("nome_tipo").ToString();
            }
        }

        private void btn_removeTipo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir este tipo de produto?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Banco.ExcluirTipo(tb_idTipoRemove.Text);
                kryptonDataGridViewTipo.DataSource = Banco.ObterTipo();
                kryptonDataGridViewTipo.Sort(kryptonDataGridViewTipo.Columns["ID Tipo"], ListSortDirection.Descending);
            }
        }


    }
}
