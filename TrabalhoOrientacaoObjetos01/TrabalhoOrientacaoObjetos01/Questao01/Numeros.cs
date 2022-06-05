using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    //    Objetivo: Dado a entrada de um valor decimal, deverá escrever o mesmo por extenso.
    //● Classe: Número
    //○ Propriedades:
    //■ Valor: double
    //○ Métodos:
    //■ ObterDecimalPorExtenso
    //■ ObterUnidadePorExtenso
    //■ ObterDezenaPorExtenso
    //■ ObterCentenaPorExtenso
    //■ ObterUnidadeDeMilharPorExtenso
    //■ ObterNumeroCompletoPorExtenso

    //● Cenários de teste unitários:
    //○ Cenário 01: Validar todos os valores decimais de 0 até 99;
    //○ Cenário 02: Validar todos os números menores que 10;
    //○ Cenário 03: Validar todos os números menores que 100;
    //○ Cenário 04: Validar 10 números, sendo um para cada centena;
    //○ Cenário 05: Validar unidade de milhar, com dez números;
    //○ Cenário 06: Validar o número completo por extenso, com 5 cenários.
    //● Classe Principal:
    //○ Conter método executar, instanciando objeto da classe citada acima,
    //permitindo o usuário escolher qual dos métodos citados acima ele deseja
    //executar.

    
    public class Numero   //Cláudio Henrique Raimundo
    {
        public double Valor;


        public string ObterMilharPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarMilhar = string.Empty;


            if (numeroDigitado >= 1000 && numeroDigitado < 2000)
            {
                Valor = numeroDigitado - 1000;
                apresentarMilhar = "mil";
            }
            if (numeroDigitado >= 2000 && numeroDigitado < 3000)
            {
                Valor = numeroDigitado - 2000;
                apresentarMilhar = "dois mil";
            }
            if (numeroDigitado >= 3000 && numeroDigitado < 4000)
            {
                Valor = numeroDigitado - 3000;
                apresentarMilhar = "três mil";
            }
            if (numeroDigitado >= 4000 && numeroDigitado < 5000)
            {
                Valor = numeroDigitado - 4000;
                apresentarMilhar = "quatro mil";
            }
            if (numeroDigitado >= 5000 && numeroDigitado < 6000)
            {
                Valor = numeroDigitado - 5000;
                apresentarMilhar = "cinco mil";
            }
            if (numeroDigitado >= 6000 && numeroDigitado < 7000)
            {
                Valor = numeroDigitado - 6000;
                apresentarMilhar = "seis mil";
            }
            if (numeroDigitado >= 7000 && numeroDigitado < 8000)
            {
                Valor = numeroDigitado - 7000;
                apresentarMilhar = "sete mil";
            }
            if (numeroDigitado >= 8000 && numeroDigitado < 9000)
            {
                Valor = numeroDigitado - 8000;
                apresentarMilhar = "oito mil";
            }
            if (numeroDigitado >= 9000 && numeroDigitado < 10000)
            {
                Valor = numeroDigitado - 9000;
                apresentarMilhar = "nove mil";
            }

            return apresentarMilhar;
        }

        public string ObterCentenaPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarCentena = string.Empty;
            var apresentarCentenaCompleta = string.Empty;

            if (numeroDigitado == 100)
            {
                Valor = numeroDigitado - 100;
                apresentarCentena = "cem";
            }
            if (numeroDigitado > 100 && numeroDigitado < 200)
            {
                apresentarCentena = "cem";
                Valor = numeroDigitado - 100;
            }
            if (numeroDigitado >= 200 && numeroDigitado < 300)
            {
                Valor = numeroDigitado - 200;
                apresentarCentena = "duzentos";
            }
            if (numeroDigitado >= 300 && numeroDigitado < 400)
            {
                Valor = numeroDigitado - 300;
                apresentarCentena = "trezentos";
            }
            if (numeroDigitado >= 400 && numeroDigitado < 500)
            {
                Valor = numeroDigitado - 400;
                apresentarCentena = "quatrocentos";
            }
            if (numeroDigitado >= 500 && numeroDigitado < 600)
            {
                Valor = numeroDigitado - 500;
                apresentarCentena = "quinhentos";
            }
            if (numeroDigitado >= 600 && numeroDigitado < 700)
            {
                Valor = numeroDigitado - 600;
                apresentarCentena = "seiscentos";
            }
            if (numeroDigitado >= 700 && numeroDigitado < 800)
            {
                Valor = numeroDigitado - 700;
                apresentarCentena = "setecentos";
            }
            if (numeroDigitado >= 800 && numeroDigitado < 900)
            {
                Valor = numeroDigitado - 800;
                apresentarCentena = "oitocentos";
            }
            if (numeroDigitado >= 900 && numeroDigitado < 1000)
            {
                Valor = numeroDigitado - 900;
                apresentarCentena = "novecentos";
            }

            return apresentarCentena;
        }

        public string ObterDezenaPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarDezena = string.Empty;

            if (numeroDigitado >= 20 && numeroDigitado < 30)
            {
                Valor = numeroDigitado - 20;
                apresentarDezena = "vinte";
            }
            if (numeroDigitado >= 30 && numeroDigitado < 40)
            {
                Valor = numeroDigitado - 30;
                apresentarDezena = "trinta";
            }
            if (numeroDigitado >= 40 && numeroDigitado < 50)
            {
                Valor = numeroDigitado - 40;
                apresentarDezena = "quarenta";
            }
            if (numeroDigitado >= 50 && numeroDigitado < 60)
            {
                Valor = numeroDigitado - 50;
                apresentarDezena = "cinquenta";
            }
            if (numeroDigitado >= 60 && numeroDigitado < 70)
            {
                Valor = numeroDigitado - 60;
                apresentarDezena = "sessenta";
            }
            if (numeroDigitado >= 70 && numeroDigitado < 80)
            {
                Valor = numeroDigitado - 70;
                apresentarDezena = "setenta";
            }
            if (numeroDigitado >= 80 && numeroDigitado < 90)
            {
                Valor = numeroDigitado - 80;
                apresentarDezena = "oitenta";
            }
            if (numeroDigitado >= 90 && numeroDigitado < 100)
            {
                Valor = numeroDigitado - 90;
                apresentarDezena = "noventa";
            }

            return apresentarDezena;
        }

        public string ObterUnidadePorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarUnidade = string.Empty;

            if (numeroDigitado == 19)
            {
                Valor = numeroDigitado - 19;
                apresentarUnidade = "dezenove";
            }
            if (numeroDigitado == 18)
            {
                Valor = numeroDigitado - 18;
                apresentarUnidade = "dezoito";
            }
            if (numeroDigitado == 17)
            {
                Valor = numeroDigitado - 17;
                apresentarUnidade = "dezessete";
            }
            if (numeroDigitado == 16)
            {
                Valor = numeroDigitado - 16;
                apresentarUnidade = "dezesseis";
            }
            if (numeroDigitado == 15)
            {
                Valor = numeroDigitado - 15;
                apresentarUnidade = "quinze";
            }
            if (numeroDigitado == 14)
            {
                Valor = numeroDigitado - 14;
                apresentarUnidade = "quatorze";
            }
            if (numeroDigitado == 13)
            {
                Valor = numeroDigitado - 13;
                apresentarUnidade = "treze";
            }
            if (numeroDigitado == 12)
            {
                Valor = numeroDigitado - 12;
                apresentarUnidade = "doze";
            }
            if (numeroDigitado == 11)
            {
                Valor = numeroDigitado - 11;
                apresentarUnidade = "onze";
            }
            if (numeroDigitado == 10)
            {
                Valor = numeroDigitado - 10;
                apresentarUnidade = "dez";
            }
            if (numeroDigitado == 9)
            {
                Valor = numeroDigitado - 9;
                apresentarUnidade = "nove";
            }
            if (numeroDigitado == 8)
            {
                Valor = numeroDigitado - 8;
                apresentarUnidade = "oito";
            }
            if (numeroDigitado == 7)
            {
                Valor = numeroDigitado - 7;
                apresentarUnidade = "sete";
            }
            if (numeroDigitado == 6)
            {
                Valor = numeroDigitado - 6;
                apresentarUnidade = "seis";
            }
            if (numeroDigitado == 5)
            {
                Valor = numeroDigitado - 5;
                apresentarUnidade = "cinco";
            }
            if (numeroDigitado == 4)
            {
                Valor = numeroDigitado - 4;
                apresentarUnidade = "quatro";
            }
            if (numeroDigitado == 3)
            {
                Valor = numeroDigitado - 3;
                apresentarUnidade = "três";
            }
            if (numeroDigitado == 2)
            {
                Valor = numeroDigitado - 2;
                apresentarUnidade = "dois";
            }
            if (numeroDigitado == 1)
            {
                Valor = numeroDigitado - 1;
                apresentarUnidade = "um";
            }
            if (numeroDigitado == 0)
            {
                apresentarUnidade = "zero";
            }



            return apresentarUnidade;
        }

        public string ObterDezenaDecimalPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarDezenaDecimal = string.Empty;

            if (numeroDigitado >= 20 && numeroDigitado < 30)
            {
                Valor = numeroDigitado - 20;
                apresentarDezenaDecimal = "vinte";
            }
            if (numeroDigitado >= 30 && numeroDigitado < 40)
            {
                Valor = numeroDigitado - 30;
                apresentarDezenaDecimal = "trinta";
            }
            if (numeroDigitado >= 40 && numeroDigitado < 50)
            {
                Valor = numeroDigitado - 40;
                apresentarDezenaDecimal = "quarenta";
            }
            if (numeroDigitado >= 50 && numeroDigitado < 60)
            {
                Valor = numeroDigitado - 50;
                apresentarDezenaDecimal = "cinquenta";
            }
            if (numeroDigitado >= 60 && numeroDigitado < 70)
            {
                Valor = numeroDigitado - 60;
                apresentarDezenaDecimal = "sessenta";
            }
            if (numeroDigitado >= 70 && numeroDigitado < 80)
            {
                Valor = numeroDigitado - 70;
                apresentarDezenaDecimal = "setenta";
            }
            if (numeroDigitado >= 80 && numeroDigitado < 90)
            {
                Valor = numeroDigitado - 80;
                apresentarDezenaDecimal = "oitenta";
            }
            if (numeroDigitado >= 90 && numeroDigitado < 100)
            {
                Valor = numeroDigitado - 90;
                apresentarDezenaDecimal = "noventa";
            }

            return apresentarDezenaDecimal;
        }

        public string ObterUnidadeDecimalPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarUnidadeDecimal = string.Empty;

            if (numeroDigitado == 19)
            {
                Valor = numeroDigitado - 19;
                apresentarUnidadeDecimal = "dezenove";
            }
            if (numeroDigitado == 18)
            {
                Valor = numeroDigitado - 18;
                apresentarUnidadeDecimal = "dezoito";
            }
            if (numeroDigitado == 17)
            {
                Valor = numeroDigitado - 17;
                apresentarUnidadeDecimal = "dezessete";
            }
            if (numeroDigitado == 16)
            {
                Valor = numeroDigitado - 16;
                apresentarUnidadeDecimal = "dezesseis";
            }
            if (numeroDigitado == 15)
            {
                Valor = numeroDigitado - 15;
                apresentarUnidadeDecimal = "quinze";
            }
            if (numeroDigitado == 14)
            {
                Valor = numeroDigitado - 14;
                apresentarUnidadeDecimal = "quatorze";
            }
            if (numeroDigitado == 13)
            {
                Valor = numeroDigitado - 13;
                apresentarUnidadeDecimal = "treze";
            }
            if (numeroDigitado == 12)
            {
                Valor = numeroDigitado - 12;
                apresentarUnidadeDecimal = "doze";
            }
            if (numeroDigitado == 11)
            {
                Valor = numeroDigitado - 11;
                apresentarUnidadeDecimal = "onze";
            }
            if (numeroDigitado == 10)
            {
                Valor = numeroDigitado - 10;
                apresentarUnidadeDecimal = "dez";
            }
            if (numeroDigitado == 9)
            {
                Valor = numeroDigitado - 9;
                apresentarUnidadeDecimal = "nove";
            }
            if (numeroDigitado == 8)
            {
                Valor = numeroDigitado - 8;
                apresentarUnidadeDecimal = "oito";
            }
            if (numeroDigitado == 7)
            {
                Valor = numeroDigitado - 7;
                apresentarUnidadeDecimal = "sete";
            }
            if (numeroDigitado == 6)
            {
                Valor = numeroDigitado - 6;
                apresentarUnidadeDecimal = "seis";
            }
            if (numeroDigitado == 5)
            {
                Valor = numeroDigitado - 5;
                apresentarUnidadeDecimal = "cinco";
            }
            if (numeroDigitado == 4)
            {
                Valor = numeroDigitado - 4;
                apresentarUnidadeDecimal = "quatro";
            }
            if (numeroDigitado == 3)
            {
                Valor = numeroDigitado - 3;
                apresentarUnidadeDecimal = "três";
            }
            if (numeroDigitado == 2)
            {
                Valor = numeroDigitado - 2;
                apresentarUnidadeDecimal = "dois";
            }
            if (numeroDigitado == 1)
            {
                Valor = numeroDigitado - 1;
                apresentarUnidadeDecimal = "um";
            }
            if (numeroDigitado == 0)
            {
                apresentarUnidadeDecimal = "zero";
            }

            return apresentarUnidadeDecimal;
        }

        public string ObterNumeroCompletoPorExtenso()
        {
            var numeroCompleto = string.Empty;

            numeroCompleto = ObterMilharPorExtenso() + ObterCentenaPorExtenso() + ObterDezenaPorExtenso() + ObterUnidadePorExtenso() + ObterDezenaDecimalPorExtenso() + ObterUnidadeDecimalPorExtenso();

            return numeroCompleto;
        }
    }
}
