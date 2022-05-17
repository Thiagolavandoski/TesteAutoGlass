//using APIProdutos.Interfaces.services;
//using APIProdutos.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace APIProdutos.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoriaController : ControllerBase
//    {
//        private readonly ICategoriaService _categoriaService;

//        public CategoriaController(ICategoriaService categoriaService)
//        {
//            _categoriaService = categoriaService;
//        }

//        [Route("All")]
//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            try
//            {
//                var result = _categoriaService.GetAll();
//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("Filter/{nome}/{origem}")]
//        [HttpGet]
//        public IActionResult GetByFilter(string nome, string origem)
//        {
//            try
//            {
//                var result = _categoriaService.GetByFilter(nome, origem);
//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("Insert")]
//        [HttpPost]
//        public IActionResult Post(Categoria categoria)
//        {
//            try
//            {
//                _categoriaService.Insert(categoria);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("Edit")]
//        [HttpPut]
//        public IActionResult Edit(Categoria categoria)
//        {
//            try
//            {
//                _categoriaService.Edit(categoria);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("Delete/{id}")]
//        [HttpDelete]
//        public IActionResult Delete(int id)
//        {
//            try
//            {
//                _categoriaService.Delete(id);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//    }
//}
