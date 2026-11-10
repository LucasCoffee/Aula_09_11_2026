Console.WriteLine("Digite um ano");
int anoInformado = int.Parse(Console.ReadLine());

if(anoInformado < 0)
{
    Console.WriteLine("Você não informou um ano valido");
}

if(anoInformado % 4  == 0)
{
    Console.WriteLine("Esse é um ano bissexto");
}
else
{
    Console.WriteLine("Esse não é um ano bissexto");

}