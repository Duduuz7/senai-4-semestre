using ControleDeInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleDeInventario.Controle;

namespace ControleInventario.Test
{
    public class ControleUnitTest
    {
        [Fact]
        public static void VerificaSeJaExisteItemEAdiciona()
        {
            var produto1 = new Produto();

            produto1.Nome = "Óculos da Catarina";
            produto1.Quantidade = 1;

            List<Produto> lista = new List<Produto>();

            var resultado1 = Controle.AdicionarProduto(lista, produto1);

            var verQuantidade1 = lista.FirstOrDefault(x => x.Nome == "Óculos da Catarina");

            Assert.NotNull(resultado1 );

            var produto2 = new Produto();
            produto2.Nome = "Óculos da Catarina";

            var resultado2 = Controle.AdicionarProduto(lista, produto2 );

            var verQuantidade2 = lista.FirstOrDefault(x => x.Nome == "Óculos da Catarina");

            Assert.Equal(2, verQuantidade2.Quantidade);
        }
    }
}
