using Microsoft.AspNetCore.Mvc;

namespace UniverseGames.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        // GET: api/categoria
        [HttpGet]
        public IActionResult Get()
        {
            var categorias = new List<string>
            {
                "Ação",
                "Aventura",
                "RPG"
            };

            return Ok(categorias);
        }

        // POST: api/categoria
        [HttpPost]
        public IActionResult Post([FromBody] string nome)
        {
            return Ok($"Categoria {nome} criada com sucesso");
        }
    }
}