Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade > 0)
{
    if(idade <= 12)
    {
        Console.WriteLine("Você é uma criança");
    } 
    else if (idade > 13 && idade <= 17)
    {
        Console.WriteLine("Você é um adolecente");
    }
    else if (idade > 18 && idade <= 59)
    {
        Console.WriteLine("Você é um adulto");
    }
    else
    {
        Console.WriteLine("Você é um idoso");
    }
} else
{
    Console.WriteLine("Idade invalida");
}



