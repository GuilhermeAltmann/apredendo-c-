using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;
using MyWebApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {

            _repository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            try {

                return Ok(_repository.ListarProdutos());
            } catch (Exception ex)
            {

                return BadRequest("Erro:" + ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            try
            {

                Produto produto = _repository.ObterProdutoPorId(id);
                return Ok(produto);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {

            try
            {

                _repository.Salvar(produto);
                return Created("/api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
