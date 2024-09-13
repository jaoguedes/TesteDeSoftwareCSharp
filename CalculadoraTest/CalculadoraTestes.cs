namespace CalculadoraTest
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, ContasBasicasTestes.Calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, ContasBasicasTestes.Calculadora.Subtrair(2, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(4, ContasBasicasTestes.Calculadora.Multiplicar(2, 2));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, ContasBasicasTestes.Calculadora.Dividir(2, 2));
        }

        [Fact]
        public void DividirPorZero()
        {
            // Verifica se uma exceção de divisão por zero é lançada
            Assert.Throws<DivideByZeroException>(() => ContasBasicasTestes.Calculadora.Dividir(2, 0));
        }
    }
}