namespace CpmPedidos.Dominio
{
    public  class Cidade : DominioBase, IExibivel
    {
        public string? Nome { get; set; }
        public string? Uf { get; set; }
        public bool Ativo { get; set; }
    }
}
