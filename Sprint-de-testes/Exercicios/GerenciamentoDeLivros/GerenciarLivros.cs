using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class GerenciarLivros
    {
        public class Livro
        {
            public string Titulo { get; set; }
        }

        public static List<Livro> livros = new List<Livro>();

        public static List<Livro> AdicionarLivro(List<Livro> livros, Livro livro)
        {
            livros.Add(livro);

            return livros;
        }
    }
}
