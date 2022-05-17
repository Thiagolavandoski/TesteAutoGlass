using APIProdutos.Context;
using APIProdutos.Interfaces.Repositories;
using APIProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProdutos.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ContextDB _context;

        public ProdutoRepository(ContextDB ContextDB)
        {
            _context = ContextDB;
        }

        public void Delete(int id)
        {
            var result = _context.Produtos.Find(id);

            result.SituacaoDoProduto = false;

            _context.Update(result);
            _context.SaveChanges();
        }

        public void Edit(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            var result = _context.Produtos.Where(x => x.SituacaoDoProduto).AsNoTracking().ToList();
            return result;
        }

        public Produto GetById(int id)
        {
            var result = _context.Produtos.Where(x => x.SituacaoDoProduto && x.CodigoDoProduto == id).FirstOrDefault();
            return result;
        }

        public List<Produto> GetByFilter(string descricaoDoProduto, string descricaoDoFornecedor)
        {
            var result = _context.Produtos.Where(x => x.DescricaoDoProduto.Contains(descricaoDoProduto) && x.DescricaoDoFornecedor.Contains(descricaoDoFornecedor)).AsNoTracking().ToList();
            return result;
        }

        public void Insert(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
    }
}
