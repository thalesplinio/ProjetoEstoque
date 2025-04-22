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
    public partial class FormDescricaoDeNivelAcesso : Form
    {
        public FormDescricaoDeNivelAcesso()
        {
            InitializeComponent();
            lb_deskNivel.Text = "Nível 0: Básico.\nNível 1: Funcionário\nNível 2: Gerente";
        }
    }
}
