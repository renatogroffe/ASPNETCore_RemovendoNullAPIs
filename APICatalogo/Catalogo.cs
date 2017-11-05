using System.Collections.Generic;

namespace APICatalogo
{
    public static class Catalogo
    {
        private static List<Item> _itens;

        static Catalogo()
        {
            _itens = new List<Item>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    _itens.Add(new Item()
                    {
                        Codigo = i.ToString("00000"),
                        Nome = "PRODUTO " + i,
                        QtdEstoque = i,
                        DadosFornecedor = new Fornecedor()
                        {
                            Codigo = "F" + i.ToString("00000"),
                            Nome = "FORNECEDOR " + i
                        }
                    });
                }
                else
                {
                    _itens.Add(new Item()
                    {
                        Codigo = i.ToString("00000"),
                        Nome = "SERVICO " + i
                    });
                }
            }
        }

        public static List<Item> ListarItens()
        {
            return _itens;
        }
    }
}