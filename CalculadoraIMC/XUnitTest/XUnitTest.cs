using System;
using Xunit;

namespace XUnitTest
{
    public class Operacoes
    {
        public static double Calculo(double peso, double altura)
        {
            return (peso / (altura * altura));
        }

    }
    public class XUnitTest
    {

        public double peso = 72;
        public double altura = 1.74;

        [Fact]
        public string CalculoIncoerente()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.NotInRange(resultado, 0, 999);
            return ("Incoerencia nos dados");


        }

        [Fact]
        public string CalculoAbaixoPeso()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 0, 18.4);
            return ("Abaixo do peso");

        }

        [Fact]
        public string CalculoPesoIdeal()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 18.5, 24.9);
            return ("Peso Ideal");

        }

        [Fact]
        public string CalculoSobrepeso()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 25, 29.9);
            return ("Sobrepeso");

        }

        [Fact]
        public string CalculoObesidade1()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 30, 34.9);
            return ("Grau de Obesidade 1");

        }

        [Fact]
        public string CalculoObesidade2()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 35, 39.9);
            return ("Grau de Obesidade 2");

        }

        [Fact]
        public string CalculoObesidade3()
        {

            var resultado = Operacoes.Calculo(peso, altura);

            Assert.InRange(resultado, 40, 999);
            return ("Grau de Obesidade 3");

        }
    }
}
