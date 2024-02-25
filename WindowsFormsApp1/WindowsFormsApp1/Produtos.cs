using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Produtos
    {
        public string id_produto { get; set; }
        public string id_usuario { get; set; }
        public string id_fornecedor { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string id_categoria { get; set; }
        public string descricao { get; set; }
        public string quantidade { get; set; }
        public string quantidade_minima { get; set; }
        public string id_tipo_produto { get; set; }
        public DateTime data_criacao { get; set; }
        public string image { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
