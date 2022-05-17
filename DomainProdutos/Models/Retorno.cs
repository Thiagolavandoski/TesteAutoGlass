using APIProdutos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProdutos.Models
{
    public class Retorno
    {
        public string Descricao { get; set; }
        public bool TemErro { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
