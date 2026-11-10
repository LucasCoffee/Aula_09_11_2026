Console.WriteLine("Digite um numero: ");
int num = 0;
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Número informado é par");
}
else
{
    Console.WriteLine("Número informado é impar");
}