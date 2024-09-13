
using ContasBasicasTestes;

namespace CalculadoraTest
{
    public class EquacaoQuadraticaTestes
    {
        [Fact]
        public void DeveEncontrarDuasRaizesReais()
        {
            // Equação: x^2 - 5x + 6 = 0 (a = 1, b = -5, c = 6)
            // Raízes esperadas: 3 e 2
            var resultado = EquacaoQuadratica.CalcularRaizes(1, -5, 6);

            Assert.Equal(3, resultado.raiz1);
            Assert.Equal(2, resultado.raiz2);
        }

        [Fact]
        public void DeveEncontrarUmaRaizReal()
        {
            // Equação: x^2 - 4x + 4 = 0 (a = 1, b = -4, c = 4)
            // Raiz esperada: 2 (duas raízes iguais)
            var resultado = EquacaoQuadratica.CalcularRaizes(1, -4, 4);

            Assert.Equal(2, resultado.raiz1);
            Assert.Equal(2, resultado.raiz2);
        }

        [Fact]
        public void DeveNaoEncontrarRaizReal()
        {
            // Equação: x^2 + x + 1 = 0 (a = 1, b = 1, c = 1)
            // Nenhuma raiz real (delta < 0)
            var resultado = EquacaoQuadratica.CalcularRaizes(1, 1, 1);

            Assert.Null(resultado.raiz1);
            Assert.Null(resultado.raiz2);
        }
    }
}
