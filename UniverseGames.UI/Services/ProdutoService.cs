using UniverseGames.UI.Models;

namespace UniverseGames.UI.Services
{
    public class ProdutoService
    {
        private readonly ApiService _api = new ApiService();

        public async Task<List<ProdutoModel>> GetProdutos()
        {
            return await _api.GetAsync<List<ProdutoModel>>("produto");
        }

        public async Task<bool> CriarProduto(ProdutoModel produto)
        {
            return await _api.PostAsync("produto", produto);
        }

        public async Task<bool> AtualizarProduto(int id, ProdutoModel produto)
        {
            return await _api.PutAsync($"produto/{id}", produto);
        }

        public async Task<bool> DeletarProduto(int id)
        {
            return await _api.DeleteAsync($"produto/{id}");
        }
    }
}