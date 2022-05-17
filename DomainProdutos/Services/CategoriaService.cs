//using APIProdutos.Interfaces.Repositories;
//using APIProdutos.Interfaces.services;
//using APIProdutos.Models;

//namespace APIProdutos.Services
//{
//    public class CategoriaService : ICategoriaService
//    {
//        private readonly ICategoriaRepository _categoriaRepository;

//        public CategoriaService(ICategoriaRepository categoriaRepository)
//        {
//            _categoriaRepository = categoriaRepository;
//        }

//        public void Delete(int id)
//        {
//            _categoriaRepository.Delete(id);
//        }

//        public void Edit(Categoria categoria)
//        {
//            _categoriaRepository.Edit(categoria);
//        }

//        public List<Categoria> GetAll()
//        {
//            var result = _categoriaRepository.GetAll();
//            return result;
//        }

//        public List<Categoria> GetByFilter(string nome, string origem)
//        {
//            var result = _categoriaRepository.GetByFilter(nome, origem);
//            return result;
//        }

//        public void Insert(Categoria categoria)
//        {
//            _categoriaRepository.Insert(categoria);
//        }

//    }
//}
