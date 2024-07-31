using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //notation que identifica um método como um método de teste
        [Fact]
        public void SomarDoisNumeros()
        {
            var n1 = 3.14;
            var n2 = 5.26;
            var valorEsperado = 8.40;

            var soma = Calculo.Somar(n1, n2);

            //Identifica se os valores sao iguais
            Assert.Equal(valorEsperado, soma); 
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 3;
            var n2 = 1;
            var valorEsperado = 2;

            var subtracao = Calculo.Subtrair(n1, n2);

            //Identifica se os valores sao iguais
            Assert.Equal(valorEsperado, subtracao);
        }

        [Fact]
        public void DividirDoisNumeros()
        {
            var n1 = 2;
            var n2 = 2;
            var valorEsperado = 1;

            var divisao = Calculo.Dividir(n1, n2);

            //Identifica se os valores sao iguais
            Assert.Equal(valorEsperado, divisao);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 3;
            var n2 = 2;
            var valorEsperado = 6;

            var multiplicacao = Calculo.Multiplicar(n1, n2);

            //Identifica se os valores sao iguais
            Assert.Equal(valorEsperado, multiplicacao);
        }

        [Fact]
        public void ModularDeUmNumero()
        {
            var n1 = -3;
            var valorEsperado = 3;

            var modulo = Calculo.Modular(n1);

            //Identifica se os valores sao iguais
            Assert.Equal(valorEsperado, modulo);
        }
    }
}
