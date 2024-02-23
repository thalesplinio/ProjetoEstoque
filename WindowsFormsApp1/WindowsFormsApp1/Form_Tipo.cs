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
    public partial class Form_Tipo : Form
    {
        public Form_Tipo()
        {
            InitializeComponent();
        }

        private void Form_Tipo_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewTipo.DataSource = Banco.ObterTipo();
            kryptonDataGridViewTipo.Sort(kryptonDataGridViewTipo.Columns["ID Tipo"], ListSortDirection.Descending);
            kryptonDataGridViewTipo.Columns[0].Width = 100;
            kryptonDataGridViewTipo.Columns[1].Width = 315;
        }

        private void btn_addTipo_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
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
