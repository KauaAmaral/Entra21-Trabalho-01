using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExemploRelogio
    {
        // Kauã Amaral

        public void Executar()
        {
            var relogio = new Relogio();

            Console.Write("Digite um horário: ");
            relogio.Horario = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(@"1 - Obter Hora Por Extenso
2 - Obterminutoporextenso
3 - ObterSegundoPorExtenso
4 - ObterHoraCompletaPorExtenso");

            var opcaoDesejada = 0;
            while ((opcaoDesejada <= 0) || (opcaoDesejada > 4))
            {
                try
                {
                    Console.WriteLine("Digite a opção desejada: ");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                    if ((opcaoDesejada <= 0) || (opcaoDesejada > 4))
                    {
                        Console.WriteLine(@"
Apenas um número do menu
");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(@"
Apenas um numero do menu
");
                }
            }

            if (opcaoDesejada == 1)
            {
                Console.WriteLine(relogio.ObterHoraPorExtenso());
            }
            else if (opcaoDesejada == 2)
            {
                Console.WriteLine(relogio.ObterMinutoPorExtenso());
            }
            else if (opcaoDesejada == 3)
            {
                Console.WriteLine(relogio.ObterSegundoPorExtenso());
            }
            else if (opcaoDesejada == 4)
            {
                Console.WriteLine(relogio.ObterHoraCompletaPorExtenso());
            }
        }
    }
}
