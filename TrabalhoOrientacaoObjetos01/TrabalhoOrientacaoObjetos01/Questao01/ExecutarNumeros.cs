using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    
    public class ExemploNumero  //Cláudio HenriqueRaimundo
    {
        public void Executar()
        {
            var numeroDigitado = new Numero();
            Console.WriteLine("Digite o numero que deseja: ");
            numeroDigitado.Valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(@"Escolha uma opção que deseja: 
1 - apresentar milhar por extenso
2 - apresentar centena por extenso
3 - apresentar dezena por extenso
4 - apresentar unidade por extenso
5 - apresentar dezena decimal por extenso
6 - apresentar unidade decimal por extenso
7 - apresentar numero completo por extenso
8 - sair");
            var opcaoEscolhida = Convert.ToDouble(Console.ReadLine());

            while (opcaoEscolhida != 8)
            {
                if (opcaoEscolhida == 1)
                {
                    Console.WriteLine($"A milhar por extenso é: {numeroDigitado.ObterMilharPorExtenso()}");
                }
                else if (opcaoEscolhida == 2)
                {
                    Console.WriteLine($"A centena por extenso é: {numeroDigitado.ObterCentenaPorExtenso()}");
                }
                else if (opcaoEscolhida == 3)
                {
                    Console.WriteLine($"A dezena por extenso é : {numeroDigitado.ObterDezenaPorExtenso()}");
                }
                else if (opcaoEscolhida == 4)
                {
                    Console.WriteLine($"A unidade por extenso é: {numeroDigitado.ObterUnidadePorExtenso()}");
                }
                else if (opcaoEscolhida == 5)
                {
                    Console.WriteLine($"A dezena decimal por extenso é: {numeroDigitado.ObterDezenaDecimalPorExtenso()}");
                }
                else if (opcaoEscolhida == 6)
                {
                    Console.WriteLine($"A unidade decimal por extenso é: {numeroDigitado.ObterUnidadeDecimalPorExtenso()}");
                }
                else if (opcaoEscolhida == 7)
                {
                    Console.WriteLine($"O numero completo por extenso é: {numeroDigitado.ObterNumeroCompletoPorExtenso()}");
                }

            }
        }
    }
}
