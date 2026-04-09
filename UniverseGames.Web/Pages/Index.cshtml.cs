using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniverseGames.Application;
using UniverseGames.Domain;

namespace UniverseGames.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GameService _service;

        public List<Game> Games { get; set; }

        public IndexModel(GameService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Games = _service.GetGames();
        }
    }
}
