using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao03;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class RelogioTests
    {
        [Theory]
        [InlineData("00:00:00", "Zero horas")]
        [InlineData("01:00:00", "Uma hora")]
        [InlineData("02:00:00", "Duas horas")]
        [InlineData("03:00:00", "Tres horas")]
        [InlineData("04:00:00", "Quatro horas")]
        [InlineData("05:00:00", "Cinco horas")]
        [InlineData("06:00:00", "Seis horas")]
        [InlineData("07:00:00", "Sete horas")]
        [InlineData("08:00:00", "Oito horas")]
        [InlineData("09:00:00", "Nove horas")]
        [InlineData("10:00:00", "Dez horas")]
        [InlineData("11:00:00", "Onze horas")]
        [InlineData("12:00:00", "Doze horas")]
        [InlineData("13:00:00", "Treze horas")]
        [InlineData("14:00:00", "Quatorze horas")]
        [InlineData("15:00:00", "Quinze horas")]
        [InlineData("16:00:00", "Dezesseis horas")]
        [InlineData("17:00:00", "Dezessete horas")]
        [InlineData("18:00:00", "Dezoito horas")]
        [InlineData("19:00:00", "Dezenove horas")]
        [InlineData("20:00:00", "Vinte horas")]
        [InlineData("21:00:00", "Vinte e uma horas")]
        [InlineData("22:00:00", "Vinte e duas horas")]
        [InlineData("23:00:00", "Vinte e três horas")]
        public void Validar_Todas_Horas_Extenso(DateTime horas, string apresentarHoras)
        {
            var relogio = new Relogio();
            relogio.Horario = horas;

            var obterHorasPorExtenso = relogio.ObterHoraPorExtenso();

            obterHorasPorExtenso.Should().Be(apresentarHoras);
        }

        [Theory]
        [InlineData("00:00:00", "zero minutos")]
        [InlineData("00:01:00", "um minutos")]
        [InlineData("00:02:00", "dois minutos")]
        [InlineData("00:03:00", "três minutos")]
        [InlineData("00:04:00", "quatro minutos")]
        [InlineData("00:05:00", "cinco minutos")]
        [InlineData("00:06:00", "seis minutos")]
        [InlineData("00:07:00", "sete minutos")]
        [InlineData("00:08:00", "oito minutos")]
        [InlineData("00:09:00", "nove minutos")]
        [InlineData("00:10:00", "Dez minutos")]
        [InlineData("00:11:00", "Onze minutos")]
        [InlineData("00:12:00", "Doze minutos")]
        [InlineData("00:13:00", "Treze minutos")]
        [InlineData("00:14:00", "Quatorze minutos")]
        [InlineData("00:15:00", "Quinze minutos")]
        [InlineData("00:16:00", "Dezesseis minutos")]
        [InlineData("00:17:00", "Dezessete minutos")]
        [InlineData("00:18:00", "Dezoito minutos")]
        [InlineData("00:19:00", "Dezenove minutos")]
        [InlineData("00:20:00", "Vinte minutos")]
        [InlineData("00:21:00", "Vinte e um minutos")]
        [InlineData("00:22:00", "Vinte e dois minutos")]
        [InlineData("00:23:00", "Vinte e três minutos")]
        [InlineData("00:24:00", "Vinte e quatro minutos")]
        [InlineData("00:25:00", "Vinte e cinco minutos")]
        [InlineData("00:26:00", "Vinte e seis minutos")]
        [InlineData("00:27:00", "Vinte e sete minutos")]
        [InlineData("00:28:00", "Vinte e oito minutos")]
        [InlineData("00:29:00", "Vinte e nove minutos")]
        [InlineData("00:30:00", "Trinta minutos")]
        [InlineData("00:31:00", "Trinta e um minutos")]
        [InlineData("00:32:00", "Trinta e dois minutos")]
        [InlineData("00:33:00", "Trinta e três minutos")]
        [InlineData("00:34:00", "Trinta e quatro minutos")]
        [InlineData("00:35:00", "Trinta e cinco minutos")]
        [InlineData("00:36:00", "Trinta e seis minutos")]
        [InlineData("00:37:00", "Trinta e sete minutos")]
        [InlineData("00:38:00", "Trinta e oito minutos")]
        [InlineData("00:39:00", "Trinta e nove minutos")]
        [InlineData("00:40:00", "Quarenta minutos")]
        [InlineData("00:41:00", "Quarenta e um minutos")]
        [InlineData("00:42:00", "Quarenta e dois minutos")]
        [InlineData("00:43:00", "Quarenta e três minutos")]
        [InlineData("00:44:00", "Quarenta e quatro minutos")]
        [InlineData("00:45:00", "Quarenta e cinco minutos")]
        [InlineData("00:46:00", "Quarenta e seis minutos")]
        [InlineData("00:47:00", "Quarenta e sete minutos")]
        [InlineData("00:48:00", "Quarenta e oito minutos")]
        [InlineData("00:49:00", "Quarenta e nove minutos")]
        [InlineData("00:50:00", "Cinquenta minutos")]
        [InlineData("00:51:00", "Cinquenta e um minutos")]
        [InlineData("00:52:00", "Cinquenta e dois minutos")]
        [InlineData("00:53:00", "Cinquenta e três minutos")]
        [InlineData("00:54:00", "Cinquenta e quatro minutos")]
        [InlineData("00:55:00", "Cinquenta e cinco minutos")]
        [InlineData("00:56:00", "Cinquenta e seis minutos")]
        [InlineData("00:57:00", "Cinquenta e sete minutos")]
        [InlineData("00:58:00", "Cinquenta e oito minutos")]
        [InlineData("00:59:00", "Cinquenta e nove minutos")]
        public void Validar_Todos_Minutos_Extenso(DateTime horas, string apresentarMinutos)
        {
            var relogio = new Relogio();
            relogio.Horario = horas;

            var obterMinutosPorExtenso = relogio.ObterMinutoPorExtenso();

            obterMinutosPorExtenso.Should().Be(apresentarMinutos);
        }

        [Theory]
        [InlineData("00:00:00", "zero segundos")]
        [InlineData("00:00:01", "um segundos")]
        [InlineData("00:00:02", "dois segundos")]
        [InlineData("00:00:03", "três segundos")]
        [InlineData("00:00:04", "quatro segundos")]
        [InlineData("00:00:05", "cinco segundos")]
        [InlineData("00:00:06", "seis segundos")]
        [InlineData("00:00:07", "sete segundos")]
        [InlineData("00:00:08", "oito segundos")]
        [InlineData("00:00:09", "nove segundos")]
        [InlineData("00:00:10", "Dez segundos")]
        [InlineData("00:00:11", "Onze segundos")]
        [InlineData("00:00:12", "Doze segundos")]
        [InlineData("00:00:13", "Treze segundos")]
        [InlineData("00:00:14", "Quatorze segundos")]
        [InlineData("00:00:15", "Quinze segundos")]
        [InlineData("00:00:16", "Dezesseis segundos")]
        [InlineData("00:00:17", "Dezessete segundos")]
        [InlineData("00:00:18", "Dezoito segundos")]
        [InlineData("00:00:19", "Dezenove segundos")]
        [InlineData("00:00:20", "Vinte segundos")]
        [InlineData("00:00:21", "Vinte e um segundos")]
        [InlineData("00:00:22", "Vinte e dois segundos")]
        [InlineData("00:00:23", "Vinte e três segundos")]
        [InlineData("00:00:24", "Vinte e quatro segundos")]
        [InlineData("00:00:25", "Vinte e cinco segundos")]
        [InlineData("00:00:26", "Vinte e seis segundos")]
        [InlineData("00:00:27", "Vinte e sete segundos")]
        [InlineData("00:00:28", "Vinte e oito segundos")]
        [InlineData("00:00:29", "Vinte e nove segundos")]
        [InlineData("00:00:30", "Trinta segundos")]
        [InlineData("00:00:31", "Trinta e um segundos")]
        [InlineData("00:00:32", "Trinta e dois segundos")]
        [InlineData("00:00:33", "Trinta e três segundos")]
        [InlineData("00:00:34", "Trinta e quatro segundos")]
        [InlineData("00:00:35", "Trinta e cinco segundos")]
        [InlineData("00:00:36", "Trinta e seis segundos")]
        [InlineData("00:00:37", "Trinta e sete segundos")]
        [InlineData("00:00:38", "Trinta e oito segundos")]
        [InlineData("00:00:39", "Trinta e nove segundos")]
        [InlineData("00:00:40", "Quarenta segundos")]
        [InlineData("00:00:41", "Quarenta e um segundos")]
        [InlineData("00:00:42", "Quarenta e dois segundos")]
        [InlineData("00:00:43", "Quarenta e três segundos")]
        [InlineData("00:00:44", "Quarenta e quatro segundos")]
        [InlineData("00:00:45", "Quarenta e cinco segundos")]
        [InlineData("00:00:46", "Quarenta e seis segundos")]
        [InlineData("00:00:47", "Quarenta e sete segundos")]
        [InlineData("00:00:48", "Quarenta e oito segundos")]
        [InlineData("00:00:49", "Quarenta e nove segundos")]
        [InlineData("00:00:50", "Cinquenta segundos")]
        [InlineData("00:00:51", "Cinquenta e um segundos")]
        [InlineData("00:00:52", "Cinquenta e dois segundos")]
        [InlineData("00:00:53", "Cinquenta e três segundos")]
        [InlineData("00:00:54", "Cinquenta e quatro segundos")]
        [InlineData("00:00:55", "Cinquenta e cinco segundos")]
        [InlineData("00:00:56", "Cinquenta e seis segundos")]
        [InlineData("00:00:57", "Cinquenta e sete segundos")]
        [InlineData("00:00:58", "Cinquenta e oito segundos")]
        [InlineData("00:00:59", "Cinquenta e nove segundos")]
        public void Validar_Todos_Segundos_Extenso(DateTime horas, string apresentarSegundos)
        {
            var relogio = new Relogio();
            relogio.Horario = horas;

            var obterSegundosPorExtenso = relogio.ObterSegundoPorExtenso();

            obterSegundosPorExtenso.Should().Be(apresentarSegundos);
        }

        [Theory]
        [InlineData("10:09:12", "Dez horas, nove minutos e Doze segundos")]
        [InlineData("09:01:22", "Nove horas, um minutos e Vinte e dois segundos")]
        [InlineData("04:11:23", "Quatro horas, Onze minutos e Vinte e três segundos")]
        [InlineData("20:59:44", "Vinte horas, Cinquenta e nove minutos e Quarenta e quatro segundos")]
        [InlineData("23:05:04", "Vinte e três horas, cinco minutos e quatro segundos")]
        [InlineData("05:04:05", "Cinco horas, quatro minutos e cinco segundos")]
        [InlineData("01:44:59", "Uma hora, Quarenta e quatro minutos e Cinquenta e nove segundos")]
        [InlineData("07:23:11", "Sete horas, Vinte e três minutos e Onze segundos")]
        [InlineData("12:22:01", "Doze horas, Vinte e dois minutos e um segundos")]
        [InlineData("22:12:09", "Vinte e duas horas, Doze minutos e nove segundos")]
        public void Validar_10_Horas_Completas_Extenso(DateTime horas, string apresentarHoras)
        {
            var relogio = new Relogio();
            relogio.Horario = horas;

            var obterHoraCompletaPorExtenso = relogio.ObterHoraCompletaPorExtenso();

            obterHoraCompletaPorExtenso.Should().Be(apresentarHoras);
        }
    }
}
