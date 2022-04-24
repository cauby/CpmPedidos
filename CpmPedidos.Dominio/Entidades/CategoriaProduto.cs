namespace CpmPedidos.Dominio
{
    public  class CategoriaProduto : DominioBase, IExibivel
    {
        public string? Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual List<Produto> ?Produtos { get; set; }
    }
}
