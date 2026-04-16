namespace UniverseGames.Application.DTOs
{
    public class ReviewDto
    {
        public int ProdutoId { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Nota { get; set; }
    }
}
