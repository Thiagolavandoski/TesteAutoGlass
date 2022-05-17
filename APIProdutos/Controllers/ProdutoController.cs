using APIProdutos.Interfaces.services;
using APIProdutos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APIProdutos.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _ProdutoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _ProdutoService = produtoService;
        }

        [Route("All")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _ProdutoService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("ById")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _ProdutoService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Filter/{DescricaoDoProduto}/{DescricaoDoFornecedor}")]
        [HttpGet]
        public IActionResult GetByFilter(string descricaoDoProduto, string descricaoDoFornecedor)
        {
            try
            {
                var result = _ProdutoService.GetByFilter(descricaoDoProduto, descricaoDoFornecedor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Insert")]
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            try
            {
                var result = _ProdutoService.Insert(produto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Edit")]
        [HttpPut]
        public IActionResult Edit(Produto produto)
        {
            try
            {
                var result = _ProdutoService.Edit(produto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _ProdutoService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

