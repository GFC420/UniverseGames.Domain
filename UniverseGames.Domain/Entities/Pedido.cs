namespace UniverseGames.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime Data { get; set; }

        public List<ItemPedido> Itens { get; set; }

        public Pagamento Pagamento { get; set; }
    }
}