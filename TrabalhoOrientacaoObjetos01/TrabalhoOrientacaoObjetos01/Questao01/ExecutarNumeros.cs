using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExemploNumero
    {
        public void Executar()
        {
            var numeroDigitado = new Numero();
            Console.WriteLine("Digite o numero que deseja: ");
            numeroDigitado.Valor = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($@"O numero completo por extenso é: {numeroDigitado.ObterDecimalPorExtenso()}
{numeroDigitado.ObterUnidadePorExtenso()}
{numeroDigitado.ObterDecimalPorExtenso()}
{numeroDigitado.ObterCentenaPorExtenso()}
{numeroDigitado.ObterMilharPorExtenso()}
{numeroDigitado.ObterNumeroCompletoPorExtenso()}");

        }
    }
}
