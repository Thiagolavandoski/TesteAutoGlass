using APIProdutos.Models;
using System.Collections.Generic;

namespace APIProdutos.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();
        List<Produto> GetByFilter(string descricaoDoProduto, string descricaoDoFornecedor);
        Produto GetById(int id);
        void Insert(Produto produto);
        void Edit(Produto produto);
        void Delete(int id);
    }
}
