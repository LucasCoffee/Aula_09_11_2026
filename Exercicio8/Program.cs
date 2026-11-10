Console.WriteLine("Digite o valor do seu salario: ");
float salario = float.Parse(Console.ReadLine());

if(salario > 0 )
{
    if(salario < 2000.00f)
    {   
        Console.WriteLine("Aumento de salario de 15%, novo valor: " +  (salario * 0.15 + salario));
    }
    if (salario >= 2000.00f && salario <= 4000.00f)
    {
        Console.WriteLine("Aumento de salario de 15%, novo valor: " + ((salario * 0.10) + salario));
    }
    if (salario > 4000.01f)
    {
        Console.WriteLine("Aumento de salario de 5%, novo valor: " + (salario * 0.05 + salario));
    }
}