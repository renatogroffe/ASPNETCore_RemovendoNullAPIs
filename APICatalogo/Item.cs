namespace APICatalogo
{
    public class Item
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int? QtdEstoque { get; set; }
        public Fornecedor DadosFornecedor { get; set; }
    }

    public class Fornecedor
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }
}