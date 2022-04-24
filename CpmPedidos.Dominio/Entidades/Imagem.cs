namespace CpmPedidos.Dominio
{
    public class Imagem : DominioBase
    {
        public string? Nome { get; set; }
        public string? NomeArquivo { get; set; }
        public bool Principal { get; set; }
        public virtual List<Produto> ?Produtos { get; set; }
    }
}
