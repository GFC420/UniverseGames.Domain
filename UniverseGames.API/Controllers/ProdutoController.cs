using Microsoft.AspNetCore.Mvc;
using UniverseGames.Application.DTOs;
using UniverseGames.Application.Services;

namespace UniverseGamess.Api.Controllers;
//{
//    [ApiController]
//    [Route("api/produtos")]
//    public class ProdutoController : ControllerBase
//    {
//        private static List<ProdutoDto> produtos = new();

//        [HttpGet]
//        public IActionResult Get() => Ok(produtos);

//        [HttpPost]
//        public IActionResult Create([FromBody] ProdutoDto p)
//        {
//            produtos.Add(p);
//            return Ok("Produto criado");
//        }

//        [HttpPut("{id}")]
//        public IActionResult Update(int id, ProdutoDto p)
//        {
//            var prod = produtos.FirstOrDefault(x => x.Id == id);
//            if (prod == null) return NotFound();

//            produtos.Remove(prod);
//            produtos.Add(p);

//            return Ok("Atualizado");
//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            var prod = produtos.FirstOrDefault(x => x.Id == id);
//            produtos.Remove(prod);
//            return Ok("Deletado");
//        }
//    }
//}
[ApiController]
[Route("api/produtos")]
public class ProdutoController : ControllerBase
{
    private readonly ProdutoService _service;

    public ProdutoController()
    {
        _service = new ProdutoService();
    }

    [HttpGet]
    public IActionResult Get() => Ok(_service.GetAll());

    [HttpPost]
    public IActionResult Create(ProdutoDto p)
    {
        _service.Add(p);
        return Ok();
    }
}