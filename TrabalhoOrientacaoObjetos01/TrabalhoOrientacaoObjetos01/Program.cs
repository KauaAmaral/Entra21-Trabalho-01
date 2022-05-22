
using TrabalhoOrientacaoObjetos01.Questao01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

Console.WriteLine(@"--------Menu-------
1- Questão 01
2- Questão 02
3- Questão 03
");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 3))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 3))
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
Console.Clear(); ;

if (opcaoDesejada == 1)
{
    ExemploNumero exemploNumero = new ExemploNumero();
    exemploNumero.Executar();
}
else if (opcaoDesejada == 2)
{
    ExemploCalendario exemploCalendario = new ExemploCalendario();
    exemploCalendario.Executar();
}
else if (opcaoDesejada == 3)
{
    ExemploRelogio exemploRelogio = new ExemploRelogio();
    exemploRelogio.Executar();
}