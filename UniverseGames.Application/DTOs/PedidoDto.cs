namespace UniverseGames.Application.DTOs
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public List<ItemPedidoDto> Itens { get; set; } = new List<ItemPedidoDto>();
    }
}
