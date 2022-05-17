//using APIProdutos.Context;
//using APIProdutos.Interfaces.Repositories;
//using APIProdutos.Models;
//using Microsoft.EntityFrameworkCore;

//namespace APIProdutos.Repositories
//{
//    public class CategoriaRepository : ICategoriaRepository
//    {
//        private readonly ContextDB _context;

//        public CategoriaRepository(ContextDB ContextDB)
//        {
//            _context = ContextDB;
//        }
//        public void Delete(int id)
//        {
//            var result = _context.Categorias.Find(id);

//            result.Ativo = false;

//            _context.Update(result);
//            _context.SaveChanges();
//        }

//        public void Edit(Categoria categoria)
//        {
//            _context.Categorias.Update(categoria);
//            _context.SaveChanges();
//        }

//        public List<Categoria> GetAll()
//        {
//            var result = _context.Categorias.Where(x => x.Ativo).AsNoTracking().ToList();
//            return result;
//        }

//        public List<Categoria> GetByFilter(string nome, string origem)
//        {
//            var result = _context.Categorias.Where(x => x.Nome.Contains(nome) && x.Origem == origem && x.Ativo).AsNoTracking().ToList();
//            return result;
//        }

//        public void Insert(Categoria categoria)
//        {
//            _context.Categorias.Add(categoria);
//            _context.SaveChanges();
//        }
//    }
//}