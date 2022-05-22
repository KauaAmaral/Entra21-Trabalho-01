using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {
        // Kauã Amaral

        public DateTime Horario;

        public string ObterHoraPorExtenso()
        {
            var horas = 0;

            var apresentarHoras = "";

            horas = Horario.Hour;

            if (horas == 00)
            {
                apresentarHoras = "Zero horas";
            }
            if (horas == 01)
            {
                apresentarHoras = "Uma hora";
            }
            if (horas == 02)
            {
                apresentarHoras = "Duas horas";
            }
            if (horas == 03)
            {
                apresentarHoras = "Tres horas";
            }
            if (horas == 04)
            {
                apresentarHoras = "Quatro horas";
            }
            if (horas == 05)
            {
                apresentarHoras = "Cinco horas";
            }
            if (horas == 06)
            {
                apresentarHoras = "Seis horas";
            }
            if (horas == 07)
            {
                apresentarHoras = "Sete horas";
            }
            if (horas == 08)
            {
                apresentarHoras = "Oito horas";
            }
            if (horas == 09)
            {
                apresentarHoras = "Nove horas";
            }
            if (horas == 10)
            {
                apresentarHoras = "Dez horas";
            }
            if (horas == 11)
            {
                apresentarHoras = "Onze horas";
            }
            if (horas == 12)
            {
                apresentarHoras = "Doze horas";
            }
            if (horas == 13)
            {
                apresentarHoras = "Treze horas";
            }
            if (horas == 14)
            {
                apresentarHoras = "Quatorze horas";
            }
            if (horas == 15)
            {
                apresentarHoras = "Quinze horas";
            }
            if (horas == 16)
            {
                apresentarHoras = "Dezesseis horas";
            }
            if (horas == 17)
            {
                apresentarHoras = "Dezessete horas";
            }
            if (horas == 18)
            {
                apresentarHoras = "Dezoito horas";
            }
            if (horas == 19)
            {
                apresentarHoras = "Dezenove horas";
            }
            if (horas == 20)
            {
                apresentarHoras = "Vinte horas";
            }
            if (horas == 21)
            {
                apresentarHoras = "Vinte e uma horas";
            }
            if (horas == 22)
            {
                apresentarHoras = "Vinte e duas horas";
            }
            if (horas == 23)
            {
                apresentarHoras = "Vinte e três horas";
            }

            return apresentarHoras;
        }

        public string ObterMinutoPorExtenso()
        {
            var minutos = 0;
            minutos = Horario.Minute;

            var primeiro = "";
            var segundo = "";
            var apresentarMinutos = "";

            var unidade = new string[20] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
            var dezena = new string[5] { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta" };

            if (minutos < 20)
            {
                primeiro = minutos.ToString();
                apresentarMinutos = unidade[Convert.ToInt32(primeiro)];
            }

            if (minutos > 19 && minutos < 60)
            {
                primeiro = minutos.ToString().Substring(1, 1);
                segundo = minutos.ToString().Substring(0, 1);
                if (primeiro != "0")
                {
                    apresentarMinutos = " e " + unidade[Convert.ToInt32(primeiro)];
                }
                apresentarMinutos = dezena[Convert.ToInt32(segundo) - 1] + apresentarMinutos;
            }

            return apresentarMinutos + " minutos";
        }

        public string ObterSegundoPorExtenso()
        {
            var segundos = 0;
            segundos = Horario.Second;

            var primeiro = "";
            var segundo = "";
            var apresentarSegundos = "";

            var unidade = new string[20] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
            var dezena = new string[5] { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta" };

            if (segundos < 20)
            {
                primeiro = segundos.ToString();
                apresentarSegundos = unidade[Convert.ToInt32(primeiro)];
            }

            if (segundos > 19 && segundos < 60)
            {
                primeiro = segundos.ToString().Substring(1, 1);
                segundo = segundos.ToString().Substring(0, 1);
                if (primeiro != "0")
                {
                    apresentarSegundos = " e " + unidade[Convert.ToInt32(primeiro)];
                }
                apresentarSegundos = dezena[Convert.ToInt32(segundo) - 1] + apresentarSegundos;
            }

            return apresentarSegundos + " segundos";
        }

        public string ObterHoraCompletaPorExtenso()
        {
            var apresentarHorarioCompleto = ObterHoraPorExtenso() + ", " + ObterMinutoPorExtenso() + " e " + ObterSegundoPorExtenso();

            return apresentarHorarioCompleto;
        }

    }
}
