Console.WriteLine("Informe o valor primeiro lado do possivel tringulo");
float ladoA = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor segundo lado do possivel tringulo");
float ladoB = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor terceiro lado do possivel tringulo");
float ladoC = float.Parse(Console.ReadLine());

if(ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
{
    Console.WriteLine("Os valores não podem serem iguais ou menor que 0");
}

if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
{
    if (ladoA == ladoB && ladoA == ladoC)
    {
        Console.WriteLine("Esse é um triangulo equilatero");
    }
    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
    {
        Console.WriteLine("Triangulo isósceles");
    }
    else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
    {
        Console.WriteLine("Triangulo escaleno");
    }
} else
{
    Console.WriteLine("Valores informados não formam um triangulo");
}