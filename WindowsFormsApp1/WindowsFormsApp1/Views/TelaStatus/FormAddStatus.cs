using Krypton.Toolkit;
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
    public partial class FormAddStatus : Form
    {
        public FormAddStatus()
        {
            InitializeComponent();
        }

        #region Set Colors Butons
        private struct RGBColorsButtons
        {
            public static Color corAzulPadrao = Color.FromArgb(42, 49, 67); // #2A3143
            //public static Color corVerdePadrao = Color.FromArgb(19, 106, 61); // #136A3D
            public static Color corVerdePadrao = Color.FromArgb(45, 153, 97); // #136A3D

        }
        #endregion

        #region Buttons Hover Color
        private void btn_addStatus_MouseEnter(object sender, EventArgs e)
        {
            btn_addCategoria.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_addStatus_MouseLeave(object sender, EventArgs e)
        {
            btn_addCategoria.BackColor = RGBColorsButtons.corAzulPadrao;
        }

        private void btn_removeStatus_MouseEnter(object sender, EventArgs e)
        {
            btn_removeCategoria.BackColor = RGBColorsButtons.corVerdePadrao;
        }

        private void btn_removeStatus_MouseLeave(object sender, EventArgs e)
        {
            btn_removeCategoria.BackColor = RGBColorsButtons.corAzulPadrao;
        }
        #endregion

        private void Form_AddStatus_Load(object sender, EventArgs e)
        {
            kryptonDataGridViewStatus.DataSource = Banco.ObterStatus();
            kryptonDataGridViewStatus.Sort(kryptonDataGridViewStatus.Columns["ID status"], ListSortDirection.Descending);
            kryptonDataGridViewStatus.Columns[0].Width = 100;
            kryptonDataGridViewStatus.Columns[1].Width = 315;
        }
        //private void btn_addStatus_Click(object sender, EventArgs e)
        //{
        //    StatusUsuarioModel status = new StatusUsuarioModel();
        //    status.nome_status = tb_nomeStatus.Text;
        //    Banco.AdicionarStatus(status);
        //    tb_nomeStatus.Clear();
        //    kryptonDataGridViewStatus.DataSource = Banco.ObterStatus();
        //    kryptonDataGridViewStatus.Sort(kryptonDataGridViewStatus.Columns["ID status"], ListSortDirection.Descending);
        //}

        private void kryptonDataGridViewStatus_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string idStatus = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // selecionando o id do usuario
                dataTable = Banco.ObterDadosStatusParaEdicao(idStatus);

                tb_idStatusRemove.Text = dataTable.Rows[0].Field<Int64>("id_status").ToString();
                tb_nomeStatusRemove.Text = dataTable.Rows[0].Field<string>("nome_status").ToString();
            }
        }
        private void btn_removeStatus_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir este status?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Banco.ExcluirStatus(tb_idStatusRemove.Text);
                kryptonDataGridViewStatus.DataSource = Banco.ObterStatus();
                kryptonDataGridViewStatus.Sort(kryptonDataGridViewStatus.Columns["ID status"], ListSortDirection.Descending);
            }
        }
    }
}
