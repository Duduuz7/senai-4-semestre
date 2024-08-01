using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GerenciamentoDeLivros.GerenciarLivros;


namespace GerenciamentoDeLivros.Test
{
    public class GerenciarLivrosUnitTest
    {
        [Fact]
        public static void VerificarSeLivroFoiAdicionadoALista()
        {
            var livro = new Livro();

            var lista = new List<Livro>();

            GerenciarLivros.AdicionarLivro(lista, livro);

            var resultado = lista.FirstOrDefault(x => x.Titulo == livro.Titulo);

            Assert.NotNull(resultado);
        }

    }
}
