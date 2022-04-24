namespace CpmPedidos.Dominio
{
    public class ProdutoPedido : DominioBase
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto ?Produto { get; set; }
        public int IdPedido { get; set; }
        public virtual Pedido? Pedido { get; set; }
    }
}
