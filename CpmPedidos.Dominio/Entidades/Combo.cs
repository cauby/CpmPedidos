namespace CpmPedidos.Dominio
{
    public class Combo : DominioBase, IExibivel
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int IdImagem { get; set; }
        public virtual Imagem? Imagem { get; set; }
        public virtual List<Produto>? Produtos { get; set; }
        public bool Ativo { get; set; }
    }
}
