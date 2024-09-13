using ContasBasicasTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTest
{
    public class VotoTestes
    {
        [Fact]
        public void NaoPodeVotar_SeMenorDe16()
        {
            Assert.Equal("Não pode votar", Voto.PodeVotar(15));
        }

        [Fact]
        public void VotoObrigatorio_Entre18E70()
        {
            Assert.Equal("Voto obrigatório", Voto.PodeVotar(18));
            Assert.Equal("Voto obrigatório", Voto.PodeVotar(35));
            Assert.Equal("Voto obrigatório", Voto.PodeVotar(70));
        }

        [Fact]
        public void VotoFacultativo_Entre16E17OuAcimaDe70()
        {

            Assert.Equal("Voto facultativo", Voto.PodeVotar(16));
            Assert.Equal("Voto facultativo", Voto.PodeVotar(17));

            Assert.Equal("Voto facultativo", Voto.PodeVotar(71));
            Assert.Equal("Voto facultativo", Voto.PodeVotar(80));
        }

        [Fact]
        public void IdadeInvalida()
        {
            Assert.Equal("Idade inválida", Voto.PodeVotar(-1));
        }
    }
}
