using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao01
{
    //Cláudio Henrique Raimundo
    public class NumeroTests
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "um")]
        [InlineData(2, "dois")]
        [InlineData(3, "três")]
        [InlineData(4, "quatro")]
        [InlineData(5, "cinco")]
        [InlineData(6, "seis")]
        [InlineData(7, "sete")]
        [InlineData(8, "oito")]
        [InlineData(9, "nove")]
        [InlineData(10, "dez")]
        [InlineData(11, "onze")]
        [InlineData(12, "doze")]
        [InlineData(13, "treze")]
        [InlineData(14, "quatorze")]
        [InlineData(15, "quinze")]
        [InlineData(16, "dezesseis")]
        [InlineData(17, "dezessete")]
        [InlineData(18, "dezoito")]
        [InlineData(19, "dezenove")]


        public void Validar_UnidadeDecimalPorExtenso(double unidadeDecimalDigitada, string unidadeDecimalPorExtenso)
        {
            var numero = new Numero();
            numero.Valor = unidadeDecimalDigitada;


            var validarUnidadeDecimal = numero.ObterUnidadeDecimalPorExtenso();
            validarUnidadeDecimal.Should().Be(unidadeDecimalPorExtenso);
        }

        [Theory]
        [InlineData(90, "noventa")]
        [InlineData(80, "oitenta")]
        [InlineData(70, "setenta")]
        [InlineData(60, "sessenta")]
        [InlineData(50, "cinquenta")]
        [InlineData(40, "quarenta")]
        [InlineData(30, "trinta")]
        [InlineData(20, "vinte")]


        public void Validar_CentenaPorExtenso(double dezenaDecimalDigitada, string dezenaDecimalPorExtenso)
        {
            var numero = new Numero();
            numero.Valor = dezenaDecimalDigitada;

            var validarDezenaDecimal = numero.ObterDezenaPorExtenso();
            validarDezenaDecimal.Should().Be(dezenaDecimalPorExtenso);
        }

        [Theory]
        [InlineData(9, "nove")]
        [InlineData(8, "oito")]
        [InlineData(7, "sete")]
        [InlineData(6, "seis")]
        [InlineData(5, "cinco")]
        [InlineData(4, "quatro")]
        [InlineData(3, "três")]
        [InlineData(2, "dois")]
        [InlineData(1, "um")]
        [InlineData(0, "zero")]

        public void Validar_UnidadePorExtenso(double unidadeDigitada, string unidadePorExtenso)
        {
            var numero = new Numero();
            numero.Valor = unidadeDigitada;

            var validarUnidade = numero.ObterUnidadePorExtenso();
            validarUnidade.Should().Be(unidadePorExtenso);
        }

        [Theory]
        [InlineData(90, "noventa")]
        [InlineData(80, "oitenta")]
        [InlineData(70, "setenta")]
        [InlineData(60, "sessenta")]
        [InlineData(50, "cinquenta")]
        [InlineData(40, "quarenta")]
        [InlineData(30, "trinta")]
        [InlineData(20, "vinte")]

        public void Validar_DezenaPorExtenso(double dezenaDigitada, string dezenaPorExtenso)
        {
            var numero = new Numero();
            numero.Valor = dezenaDigitada;

            var validarDezena = numero.ObterDezenaPorExtenso();
            validarDezena.Should().Be(dezenaPorExtenso);
        }

        [Theory]
        [InlineData(105, "cento e cinco")]
        [InlineData(107, "cento e sete")]
        [InlineData(108, "cento e oito")]
        [InlineData(109, "cento e nove")]
        [InlineData(110, "cento e dez")]
        [InlineData(121, "cento e vinte e um")]
        [InlineData(131, "cento e trinta e um")]
        [InlineData(141, "cento e quarenta e um")]
        [InlineData(151, "cento e cinquenta e um")]
        [InlineData(178, "cento e setenta e oito")]
        [InlineData(205, "duzento e cinco")]
        [InlineData(206, "duzento e seis")]
        [InlineData(207, "duzento e sete")]
        [InlineData(208, "duzento e oito")]
        [InlineData(209, "duzento e nove")]
        [InlineData(210, "duzento e dez")]
        [InlineData(211, "duzento e onze")]
        [InlineData(212, "duzento e doze")]
        [InlineData(221, "duzento e vinte e um")]
        [InlineData(231, "duzento e trinta e um")]
        [InlineData(305, "trezentos e cinco")]
        [InlineData(307, "trezentos e sete")]
        [InlineData(310, "trezentos e dez")]
        [InlineData(325, "trezentos e vinte e cinco")]
        [InlineData(327, "trezentos e vinte e sete")]
        [InlineData(328, "trezentos e vinte e oito")]
        [InlineData(330, "trezentos e trinta")]
        [InlineData(331, "trezentos e trinta e um")]
        [InlineData(332, "trezentos e trinta e dois")]
        [InlineData(334, "trezentos e trinta e quatro")]
        [InlineData(405, "quatrocentos e cinco")]
        [InlineData(448, "quatrocentos e quarenta e oito")]
        [InlineData(449, "quatrocentos e quarenta e nove")]
        [InlineData(450, "quatrocentos e cinquenta")]
        [InlineData(487, "quatrocentos e oitenta e sete")]
        [InlineData(489, "quatrocentos e oitenta e nove")]
        [InlineData(491, "quatrocentos e noventa e um")]
        [InlineData(492, "quatrocentos e noventa e dois")]
        [InlineData(493, "quatrocentos e noventa e três")]
        [InlineData(495, "quatrocentos e noventa e cinco")]
        [InlineData(505, "quinhentos e cinco")]
        [InlineData(506, "quinhentos e seis")]
        [InlineData(509, "quinhentos e nove")]
        [InlineData(510, "quinhentos e dez")]
        [InlineData(520, "quinhentos e vinte")]
        [InlineData(530, "quinhentos e trinta")]
        [InlineData(540, "quinhentos e quarenta")]
        [InlineData(550, "quinhentos e cinquenta")]
        [InlineData(560, "quinhentos e sessenta")]
        [InlineData(570, "quinhentos e setenta")]
        [InlineData(605, "seiscento e cinco")]
        [InlineData(606, "seiscento e seis")]
        [InlineData(610, "seiscento e dez")]
        [InlineData(620, "seiscento e vinte")]
        [InlineData(630, "seiscento e trinta")]
        [InlineData(647, "seiscento e quarenta e sete")]
        [InlineData(624, "seiscento e vinte e quatro")]
        [InlineData(648, "seiscento e quarenta e oito")]
        [InlineData(699, "seiscento e noventa e nove")]
        [InlineData(683, "seiscento e oitenta e três")]
        [InlineData(708, "setecentos e oito")]
        [InlineData(710, "setecentos e dez")]
        [InlineData(719, "setecentos e dezenove")]
        [InlineData(789, "setecentos e oitenta e nove")]
        [InlineData(777, "setecentos e setenta e sete")]
        [InlineData(748, "setecentos e quarenta e oito")]
        [InlineData(743, "setecentos e quarenta e três")]
        [InlineData(722, "setecentos e vinte e dois")]
        [InlineData(741, "setecentos e quarenta e um")]
        [InlineData(740, "setecentos e quarenta")]
        [InlineData(854, "oitocentos e cinquenta e quatro")]
        [InlineData(894, "oitocentos e noventa e quatro")]
        [InlineData(823, "oitocentos e vinte e três")]
        [InlineData(877, "oitocentos e setenta e sete")]
        [InlineData(888, "oitocentos e oitenta e oito")]
        [InlineData(855, "oitocentos e cinquenta e cinco")]
        [InlineData(847, "oitocentos e quarenta e sete")]
        [InlineData(891, "oitocentos e noventa e um")]
        [InlineData(812, "oitocentos e doze")]
        [InlineData(847, "oitocentos e quarenta e sete")]
        [InlineData(905, "novecentos e cinco")]
        [InlineData(906, "novecentos e seis")]
        [InlineData(915, "novecentos e quinze")]
        [InlineData(925, "novecentos e vinte e cinco")]
        [InlineData(935, "novecentos e trinta e cinco")]
        [InlineData(945, "novecentos e quarenta e cinco")]
        [InlineData(955, "novecentos e cinquenta e cinco")]
        [InlineData(965, "novecentos e sessenta e cinco")]
        [InlineData(975, "novecentos e setenta e cinco")]
        [InlineData(985, "novecentos e oitenta e cinco")]

        public void Validar_Centena_PorExtenso(double centenaDigitada, string centenaPorExntenso)
        {
            var numero = new Numero();
            numero.Valor = centenaDigitada;

            var validarCentena = numero.ObterCentenaPorExtenso();
            validarCentena.Should().Be(centenaPorExntenso);
        }

        [Theory]


    }
}

