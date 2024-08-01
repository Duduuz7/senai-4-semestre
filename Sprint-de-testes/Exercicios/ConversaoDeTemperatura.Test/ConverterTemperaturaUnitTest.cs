using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTemperatura.Test
{
    
    public class ConverterTemperaturaUnitTest
    {
        [Fact]
        public static void ConverteTemperaturaDeCelciusParaFahrenheit() 
        {
            var celsius = 24;

            var esperadoFahrenheit = 75.2;

            var resultado = ConverterTemperatura.ConverterCelsiusParaFahrenheit(celsius);

            Assert.Equal(esperadoFahrenheit, resultado);
        }
    }
}
