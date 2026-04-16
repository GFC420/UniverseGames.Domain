using UniverseGames.UI.Models;

namespace UniverseGames.UI.Services
{
    public class CategoriaService
    {
        private readonly ApiService _api = new ApiService();

        public async Task<List<CategoriaModel>> GetCategorias()
        {
            return await _api.GetAsync<List<CategoriaModel>>("categoria");
        }
    }
}