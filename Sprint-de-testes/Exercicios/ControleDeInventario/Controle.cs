using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeInventario
{
    public class Controle
    {
        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
        }


        public static List<Produto> AdicionarProduto(List<Produto> produtos, Produto produto)
        {

            var res = produtos.FirstOrDefault(x => x.Nome == produto.Nome);

          
                if (res != null)
                {
                    res.Quantidade += 1;
                } else
                {
                    produtos.Add(produto);
                }
       

            return produtos;

        }

        //public static int ObterQuantidade(string nome)
        //{

        //}
    }
}
