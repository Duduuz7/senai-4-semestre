using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeEmail
{
    public class ValidarEmail
    {
        public static bool ValidarEmailB(string email) 
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }
    }
}
