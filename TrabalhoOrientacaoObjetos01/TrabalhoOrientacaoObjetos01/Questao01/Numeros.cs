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
    public class Numero
    {
        public double Valor;

        public string ObterDecimalPorExtenso()
        {
            var apresentarUnidade = "";
            var numeroDigitado = Valor;
            var unidade = new string[20] {"zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze",
"doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezeoito", "dezenove"};
            var dezena = new string[9] { "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            var primeiro = string.Empty;
            var segundo = string.Empty;
            if (numeroDigitado < 20)
            {


                primeiro = numeroDigitado.ToString();
                apresentarUnidade = unidade[Convert.ToInt32(primeiro)];
            }

            if (numeroDigitado > 19 && numeroDigitado < 100)
            {
                primeiro = numeroDigitado.ToString().Substring(1, 1);//1.23
                segundo = numeroDigitado.ToString().Substring(0, 1);
                if (primeiro != "0")
                {
                    apresentarUnidade = " e " + unidade[Convert.ToInt32(primeiro)];
                }
                apresentarUnidade = dezena[Convert.ToInt32(segundo) - 1] + apresentarUnidade;
            }

            return apresentarUnidade;
        }
        public string ObterUnidadePorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarUnidade = string.Empty;
            var primeiro = string.Empty;
            var conversaoParaString = Convert.ToString(numeroDigitado);
            var valorTotalDeCaracter = conversaoParaString.Length;


            var unidadeInteiro = new string[20] {"zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze",
"quinze", "dezesseis", "dezesete", "dezoito", "dezenove"};

            if (numeroDigitado < 20)
            {
                primeiro = numeroDigitado.ToString();
                apresentarUnidade = unidadeInteiro[Convert.ToInt32(primeiro)];
            }

            return apresentarUnidade;
        }

        public string ObterDezenaPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarDezena = "";

            if (numeroDigitado == 20)
            {
                apresentarDezena = "vinte";
            }
            if (numeroDigitado == 30)
            {
                apresentarDezena = "trinta";
            }
            if (numeroDigitado == 40)
            {
                apresentarDezena = "quarenta";
            }
            if (numeroDigitado == 50)
            {
                apresentarDezena = "cinquenta";
            }
            if (numeroDigitado == 60)
            {
                apresentarDezena = "sessenta";
            }
            if (numeroDigitado == 70)
            {
                apresentarDezena = "setenta";
            }
            if (numeroDigitado == 80)
            {
                apresentarDezena = "oitenta";
            }
            if (numeroDigitado == 90)
            {
                apresentarDezena = "noventa";
            }

            return apresentarDezena + ObterUnidadePorExtenso();
        }


        public string ObterCentenaPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarCentena = "";

            if (numeroDigitado == 100)
            {
                apresentarCentena = "cem";
            }
            if (numeroDigitado == 200)
            {
                apresentarCentena = "duzentos";
            }
            if (numeroDigitado == 300)
            {
                apresentarCentena = "tezentos";
            }
            if (numeroDigitado == 400)
            {
                apresentarCentena = "quatrozentos";
            }
            if (numeroDigitado == 500)
            {
                apresentarCentena = "quinhentos";
            }
            if (numeroDigitado == 600)
            {
                apresentarCentena = "seiscentos";
            }
            if (numeroDigitado == 700)
            {
                apresentarCentena = "setecentos";
            }
            if (numeroDigitado == 800)
            {
                apresentarCentena = "oitocentos";
            }
            if (numeroDigitado == 900)
            {
                apresentarCentena = "novecentos";
            }

            return apresentarCentena;
        }

        public string ObterMilharPorExtenso()
        {
            var numeroDigitado = Valor;
            var apresentarMilhar = "";

            if (numeroDigitado == 1000)
            {
                apresentarMilhar = "mil";
            }
            if (numeroDigitado == 2000)
            {
                apresentarMilhar = "dois mil";
            }
            if (numeroDigitado == 3000)
            {
                apresentarMilhar = "três mil";
            }
            if (numeroDigitado == 4000)
            {
                apresentarMilhar = "quatro mil";
            }
            if (numeroDigitado == 5000)
            {
                apresentarMilhar = "cinco mil";
            }
            if (numeroDigitado == 6000)
            {
                apresentarMilhar = "seis mil";
            }
            if (numeroDigitado == 7000)
            {
                apresentarMilhar = "sete mil";
            }
            if (numeroDigitado == 8000)
            {
                apresentarMilhar = "oito mil";
            }
            if (numeroDigitado == 9000)
            {
                apresentarMilhar = "nove mil";
            }

            return apresentarMilhar;
        }

        public string ObterNumeroCompletoPorExtenso()
        {
            var numeroCompleto = "";

            numeroCompleto = ObterMilharPorExtenso() + ObterCentenaPorExtenso() + ObterDezenaPorExtenso() + ObterUnidadePorExtenso() + ObterDecimalPorExtenso();

            return numeroCompleto;
        }
    }
}
