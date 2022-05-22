using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    //    Objetivo: Dado a entrada de uma data deverá escrever a mesma por extenso.
    //● Classe: Calendário
    //○ Propriedades:
    //■ Data: DateTime
    //○ Métodos:
    //■ ObterMesPorExtenso
    //■ ObterDiaPorExtenso
    //■ ObterAnoPorExtenso
    //■ ObterDataCompletaPorExtenso
    //● Cenários de teste unitários:
    //○ Cenário 01: Validar todos os meses por extenso;
    //○ Cenário 02: Validar todos os dias por extenso;
    //○ Cenário 03: Validar todos os anos a partir de 1970 até 2030 por extenso;
    //○ Cenário 04: validar doze datas, sendo uma data por mês.
    //● Classe principal: ExecutarCalendario
    //○ Conter método executar, instanciando objeto da classe citada acima,
    //permitindo o usuário escolher qual dos métodos citados acima ele deseja
    //executar.



    //Nome: João Vitor Altermann Martinelli
    public class Calendario
    {
        public DateTime Data;

        public string Dia()
        {

            var dia = Data.ToString().Substring(0, 2);
            var diaPorExtenso = "";

            if ((dia == "1") || (dia == "01"))
            {
                diaPorExtenso = "Um";
            }
            if ((dia == "2") || (dia == "02"))
            {
                diaPorExtenso = "Dois";
            }
            if ((dia == "3") || (dia == "03"))
            {
                diaPorExtenso = "Três";
            }
            if ((dia == "4") || (dia == "04"))
            {
                diaPorExtenso = "Quatro";
            }
            if ((dia == "5") || (dia == "05"))
            {
                diaPorExtenso = "Cinco";
            }
            if ((dia == "6") || (dia == "06"))
            {
                diaPorExtenso = "Seis";
            }
            if ((dia == "7") || (dia == "07"))
            {
                diaPorExtenso = "Sete";
            }
            if ((dia == "8") || (dia == "08"))
            {
                diaPorExtenso = "Oito";
            }
            if ((dia == "9") || (dia == "09"))
            {
                diaPorExtenso = "Nove";
            }
            if (dia == "10")
            {
                diaPorExtenso = "Dez";
            }
            if (dia == "11")
            {
                diaPorExtenso = "Onze";
            }
            if (dia == "12")
            {
                diaPorExtenso = "Doze";
            }
            if (dia == "13")
            {
                diaPorExtenso = "Treze";
            }
            if (dia == "14")
            {
                diaPorExtenso = "Quatorze";
            }
            if (dia == "15")
            {
                diaPorExtenso = "Quinze";
            }
            if (dia == "16")
            {
                diaPorExtenso = "Dezeseis";
            }
            if (dia == "17")
            {
                diaPorExtenso = "Dezessete";
            }
            if (dia == "18")
            {
                diaPorExtenso = "Dezoito";
            }
            if (dia == "19")
            {
                diaPorExtenso = "Dezenove";
            }
            if (dia == "20")
            {
                diaPorExtenso = "vinte";
            }
            if (dia == "21")
            {
                diaPorExtenso = "vinte e um";
            }
            if (dia == "22")
            {
                diaPorExtenso = "vinte e dois";
            }
            if (dia == "23")
            {
                diaPorExtenso = "vinte e três";
            }
            if (dia == "24")
            {
                diaPorExtenso = "vinte e quatro";
            }
            if (dia == "25")
            {
                diaPorExtenso = "vinte e cinco";
            }
            if (dia == "26")
            {
                diaPorExtenso = "vinte e seis";
            }
            if (dia == "27")
            {
                diaPorExtenso = "vinte e sete";
            }
            if (dia == "28")
            {
                diaPorExtenso = "vinte e oito";
            }
            if (dia == "29")
            {
                diaPorExtenso = "vinte e nove";
            }
            if (dia == "30")
            {
                diaPorExtenso = "Trinta";
            }
            if (dia == "31")
            {
                diaPorExtenso = "Trinta e um";
            }

            return diaPorExtenso;
        }

        public string Mes()
        {
            var conversorMesExtenso = Data.ToString("MMMM");

            return conversorMesExtenso;
        }

        public string Ano()
        {
            var ano = Data.ToString().Substring(6, 4);
            var anoPorExtenso = "";

            if (ano == "1970")
            {
                anoPorExtenso = "Mil novecentos e setenta";
            }
            else if (ano == "1971")
            {
                anoPorExtenso = "Mil novecentos e setenta e um";
            }
            else if (ano == "1972")
            {
                anoPorExtenso = "Mil novecentos e setenta e dois";
            }
            else if (ano == "1973")
            {
                anoPorExtenso = "Mil novecentos e setenta e três";
            }
            else if (ano == "1974")
            {
                anoPorExtenso = "Mil novecentos e setenta e quatro";
            }
            else if (ano == "1975")
            {
                anoPorExtenso = "Mil novecentos e setenta e cinco";
            }
            else if (ano == "1976")
            {
                anoPorExtenso = "Mil novecentos e setenta e seis";
            }
            else if (ano == "1977")
            {
                anoPorExtenso = "Mil novecentos e setenta e sete";
            }
            else if (ano == "1978")
            {
                anoPorExtenso = "Mil novecentos e setenta e oito";
            }
            else if (ano == "1979")
            {
                anoPorExtenso = "Mil novecentos e setenta e nove";
            }
            else if (ano == "1980")
            {
                anoPorExtenso = "Mil novecentos e oitenta";
            }
            else if (ano == "1981")
            {
                anoPorExtenso = "Mil novecentos e oitenta e um";
            }
            else if (ano == "1982")
            {
                anoPorExtenso = "Mil novecentos e oitenta e dois";
            }
            else if (ano == "1983")
            {
                anoPorExtenso = "Mil novecentos e oitenta e três";
            }
            else if (ano == "1984")
            {
                anoPorExtenso = "Mil novecentos e oitenta e quatro";
            }
            else if (ano == "1985")
            {
                anoPorExtenso = "Mil novecentos e oitenta e cinco";
            }
            else if (ano == "1986")
            {
                anoPorExtenso = "Mil novecentos e oitenta e seis";
            }
            else if (ano == "1987")
            {
                anoPorExtenso = "Mil novecentos e oitenta e sete";
            }
            else if (ano == "1988")
            {
                anoPorExtenso = "Mil novecentos e oitenta e oito";
            }
            else if (ano == "1989")
            {
                anoPorExtenso = "Mil novecentos e oitenta e nove";
            }
            else if (ano == "1990")
            {
                anoPorExtenso = "Mil novecentos e noventa";
            }
            else if (ano == "1991")
            {
                anoPorExtenso = "Mil novecentos e noventa e um";
            }
            else if (ano == "1992")
            {
                anoPorExtenso = "Mil novecentos e noventa e dois";
            }
            else if (ano == "1993")
            {
                anoPorExtenso = "Mil novecentos e noventa e três";
            }
            else if (ano == "1994")
            {
                anoPorExtenso = "Mil novecentos e noventa e quatro";
            }
            else if (ano == "1995")
            {
                anoPorExtenso = "Mil novecentos e noventa e cinco";
            }
            else if (ano == "1996")
            {
                anoPorExtenso = "Mil novecentos e noventa e seis";
            }
            else if (ano == "1997")
            {
                anoPorExtenso = "Mil novecentos e noventa e sete";
            }
            else if (ano == "1998")
            {
                anoPorExtenso = "Mil novecentos e noventa e oito";
            }
            else if (ano == "1999")
            {
                anoPorExtenso = "Mil novecentos e noventa e nove";
            }
            else if (ano == "2000")
            {
                anoPorExtenso = "Dois mil";
            }
            else if (ano == "2001")
            {
                anoPorExtenso = "Dois mil e um";
            }
            else if (ano == "2002")
            {
                anoPorExtenso = "Dois mil e dois";
            }
            else if (ano == "2003")
            {
                anoPorExtenso = "Dois mil e três";
            }
            else if (ano == "2004")
            {
                anoPorExtenso = "Dois mil e quatro";
            }
            else if (ano == "2005")
            {
                anoPorExtenso = "Dois mil e cinco";
            }
            else if (ano == "2006")
            {
                anoPorExtenso = "Dois mil e seis";
            }
            else if (ano == "2007")
            {
                anoPorExtenso = "Dois mil e sete";
            }
            else if (ano == "2008")
            {
                anoPorExtenso = "Dois mil e oito";
            }
            else if (ano == "2009")
            {
                anoPorExtenso = "Dois mil e nove";
            }
            else if (ano == "2010")
            {
                anoPorExtenso = "Dois mil e dez";
            }
            else if (ano == "2011")
            {
                anoPorExtenso = "Dois mil e onze";
            }
            else if (ano == "2012")
            {
                anoPorExtenso = "Dois mil e doze";
            }
            else if (ano == "2013")
            {
                anoPorExtenso = "Dois mil e treze";
            }
            else if (ano == "2014")
            {
                anoPorExtenso = "Dois mil e quatorze";
            }
            else if (ano == "2015")
            {
                anoPorExtenso = "Dois mil e quinze";
            }
            else if (ano == "2016")
            {
                anoPorExtenso = "Dois mil e dezeseis";
            }
            else if (ano == "2017")
            {
                anoPorExtenso = "Dois mil dezesete";
            }
            else if (ano == "2018")
            {
                anoPorExtenso = "Dois mil e dezoito";
            }
            else if (ano == "2019")
            {
                anoPorExtenso = "Dois mil e dezenove";
            }
            else if (ano == "2020")
            {
                anoPorExtenso = "Dois mil e vinte";
            }
            else if (ano == "2021")
            {
                anoPorExtenso = "Dois mil e vinte e um";
            }
            else if (ano == "2022")
            {
                anoPorExtenso = "Dois mil e vinte e dois";
            }
            else if (ano == "2023")
            {
                anoPorExtenso = "Dois mil e vinte e três";
            }
            else if (ano == "2024")
            {
                anoPorExtenso = "Dois mil e vinte e quatro";
            }
            else if (ano == "2025")
            {
                anoPorExtenso = "Dois mil e vinte e cinco";
            }
            else if (ano == "2026")
            {
                anoPorExtenso = "Dois mil e vinte e seis";
            }
            else if (ano == "2027")
            {
                anoPorExtenso = "Dois mil e vinte e sete";
            }
            else if (ano == "2028")
            {
                anoPorExtenso = "Dois mil e vinte e oito";
            }
            else if (ano == "2029")
            {
                anoPorExtenso = "Dois mil e vinte e nove";
            }
            else if (ano == "2030")
            {
                anoPorExtenso = "Dois mil mil e trinta";
            }
            else
            {
                anoPorExtenso = "Não encontrado";
            }

            return anoPorExtenso;
        }

    }
}
