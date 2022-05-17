using System.ComponentModel.DataAnnotations;

namespace APIProdutos.Models
{
    public class Produto
    {
        [Required]
        public int CodigoDoProduto { get; set; }
        [Required]
        public string DescricaoDoProduto { get; set; }
        public bool SituacaoDoProduto { get; set; }
        public DateTime DataDeFabricação { get; set; }
        public DateTime DataDeValidade { get; set; }
        public int CodigoDoFornecedor { get; set; }
        public string DescricaoDoFornecedor { get; set; }
        public string CNPJDoFornecedor { get; set; }
    }
}
