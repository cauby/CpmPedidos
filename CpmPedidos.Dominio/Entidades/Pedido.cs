namespace CpmPedidos.Dominio
{
    public class Pedido : DominioBase
    {
        public string? Numero { get; set; }
        public decimal ValorTotal { get; set;}
        public TimeSpan Entrega { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<ProdutoPedido> ?Produtos { get; set; }
    }
}
