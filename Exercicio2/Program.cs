float num1;
float num2;

Console.WriteLine("Digite o primeiro número decimal");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número decimal");
num2 = float.Parse(Console.ReadLine());

if(num1 == 0  || num2 == 0)
{
    Console.WriteLine("Valor nulo foi enviado");

}


if (num1 > num2)
{
    Console.WriteLine("O primeiro valor é maior que o segundo ");

}
else if(num1 < num2)
{
    Console.WriteLine("O segundo valor é maior que o segundo ");

}
else if (num2 == num1)
{
    Console.WriteLine("Os dois valores são iguais ");

}