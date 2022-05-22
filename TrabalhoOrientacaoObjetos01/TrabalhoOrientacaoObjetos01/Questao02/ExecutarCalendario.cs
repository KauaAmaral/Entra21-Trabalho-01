using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    internal class ExemploCalendario
    {
        //Nome: João Vitor Altermann Martinelli
        public void Executar()
        {
            var opcaoValida = false;
            Calendario calendario = new Calendario();
            var opcaoDesejada = 0;

            while (opcaoValida == false)
            {
                try
                {
                    Console.Write("Digite uma data: ");
                    calendario.Data = Convert.ToDateTime(Console.ReadLine());
                    opcaoValida = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Data invalida");
                }
            }
            opcaoValida = false;
            while (opcaoValida == false)
            {
                try
                {
                    Console.WriteLine(@"Escolha a opção que deseja converter para extenso: 
1-Dia    2-Mês   3-Ano   4-Data Completa :");
                    opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                    if ((opcaoDesejada <= 0) || (opcaoDesejada > 4))
                    {
                        Console.WriteLine("Opção invalida");
                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção invalida");
                }
            }

            if (opcaoDesejada == 1)
            {
                Console.WriteLine($"Dia por extenso é {calendario.Dia()}");
            }
            else if (opcaoDesejada == 2)
            {
                Console.WriteLine($"Mês por extenso é {calendario.Mes()}");
            }
            else if (opcaoDesejada == 3)
            {
                Console.WriteLine($"Ano por extenso é {calendario.Ano()}");
            }
            else if (opcaoDesejada == 4)
            {
                Console.WriteLine($"Data completa por extenso é: {calendario.Dia()} de: {calendario.Mes()} de: {calendario.Ano()}");
            }
            opcaoValida = false;
        }
    }
}
