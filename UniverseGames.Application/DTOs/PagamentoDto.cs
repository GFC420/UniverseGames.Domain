namespace UniverseGames.Application.DTOs
{
    public class PagamentoDto
    {
        public int PedidoId { get; set; }
        public string Metodo { get; set; } = string.Empty; // PIX, Cartão
    }
}
