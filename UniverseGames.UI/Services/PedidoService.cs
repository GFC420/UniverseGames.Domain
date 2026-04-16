using UniverseGames.UI.Models;

namespace UniverseGames.UI.Services
{
    public class PedidoService
    {
        private readonly ApiService _api = new ApiService();

        public async Task<List<PedidoModel>> GetPedidos()
        {
            return await _api.GetAsync<List<PedidoModel>>("pedido");
        }
    }
}