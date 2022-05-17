using APIProdutos.Models;
using DomainProdutos.Models;

namespace APIProdutos.Interfaces.services
{
    public interface IProdutoService
    {
        public Retorno GetAll();
        public Retorno GetByFilter(string descricaoDoProduto, string descricaoDoFornecedor);
        Retorno GetById(int id);
        public Retorno Insert(Produto produto);
        public Retorno Edit(Produto produto);
        public void Delete(int id);
    }
}
