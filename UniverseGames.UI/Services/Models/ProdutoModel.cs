namespace UniverseGames.UI.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }

        // opcional (pra exibir no grid)
        public string CategoriaNome { get; set; }
    }
}