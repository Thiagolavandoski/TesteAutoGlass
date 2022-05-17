using APIProdutos.Interfaces.Repositories;
using APIProdutos.Interfaces.services;
using APIProdutos.Models;
using DomainProdutos.Models;

namespace APIProdutos.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Delete(int id)
        {
            _produtoRepository.Delete(id);
        }

        public Retorno Edit(Produto produto)
        {
            try
            {
                if (produto.DataDeFabricação >= produto.DataDeValidade)
                {
                    var result = new Retorno
                    {
                        Descricao = "Data de fabricação não pode ser maior ou igual a data de validade",
                        TemErro = true
                    };
                    return result;
                }
                else
                {
                    _produtoRepository.Edit(produto);
                    var result = new Retorno
                    {
                        Descricao = "Sucesso",
                        TemErro = false
                    };
                    return result;
                }

            }
            catch (Exception e)
            {
                var result = new Retorno
                {
                    Descricao = e.Message,
                    TemErro = true
                };
                return result;
            }
        }

        public Retorno GetAll()
        {
            try
            {
                var produtoList = _produtoRepository.GetAll();


                var result = new Retorno
                {
                    Descricao = produtoList.Any() ? "Sucesso" : "Não existe registros",
                    TemErro = false,
                    Produtos = produtoList
                };
                return result;
            }
            catch (Exception e)
            {
                var result = new Retorno
                {
                    Descricao = e.Message,
                    TemErro = true
                };
                return result;
            }      
        }

        public Retorno GetById(int id)
        {
            try
            {
                var produto = _produtoRepository.GetById(id);
                var produtoList = new List<Produto>();

                if (produto != null) produtoList.Add(produto);
                
                var result = new Retorno
                {
                    Descricao = produto != null ? "Sucesso" : "Não existe registros",
                    TemErro = false,
                    Produtos = produtoList
                };
                return result;
            }
            catch (Exception e)
            {
                var result = new Retorno
                {
                    Descricao = e.Message,
                    TemErro = true
                };
                return result;
            }
        }

        public Retorno GetByFilter(string descricaoDoProduto, string descricaoDoFornecedor)
        {
            try
            {
                var produtoList = _produtoRepository.GetByFilter(descricaoDoProduto, descricaoDoFornecedor);
                var result = new Retorno
                {
                    Descricao = produtoList.Any() ? "Sucesso" : "Não existe registros",
                    TemErro = false,
                    Produtos = produtoList
                };
                return result;
            }
            catch (Exception e)
            {
                var result = new Retorno
                {
                    Descricao = e.Message,
                    TemErro = true
                };
                return result;
            }          
        }

        public Retorno Insert(Produto produto)
        {            
            try
            {
                if (produto.DataDeFabricação >= produto.DataDeValidade)
                {
                    var result = new Retorno
                    {
                        Descricao = "Data de fabricação não pode ser maior ou igual a data de validade",
                        TemErro = true
                    };
                    return result;
                }
                else
                {
                    _produtoRepository.Insert(produto);
                    var result = new Retorno
                    {
                        Descricao = "Sucesso",
                        TemErro = false
                    };
                    return result;
                }
                
            }
            catch (Exception e)
            {
                var result = new Retorno
                {
                    Descricao = e.Message,
                    TemErro = true
                };
                return result;
            }
        }
    }
}
