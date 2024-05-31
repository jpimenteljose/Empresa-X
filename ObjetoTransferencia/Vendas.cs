using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
    }
}
