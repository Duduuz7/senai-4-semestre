using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeEmail.Test
{
    public class ValidarEmailUnitTest
    {
        [Theory]
        [InlineData("eduardo@email.com")]
        [InlineData("eduardoemail.com")]
        [InlineData("eduardo@emailcom")]

        public static void ValidaSeEmailContemArrobaEPonto(string email)
        {
            var resultado = ValidarEmail.ValidarEmailB(email);

            Assert.True(resultado);
        }

    }
}
