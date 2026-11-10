using System.Runtime.Intrinsics.X86;

Console.WriteLine("Digite o valor do seu peso em quilos: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do sua altura em centimetros: ");
float altura = float.Parse(Console.ReadLine()) / 100;

float imc = 0f;

imc = peso / (altura * altura);

if(imc < 18.5)
{
    Console.WriteLine("Abaixo do peso: " + imc);
}
else if( imc >= 18.5f && imc < 24.9f)
{
    Console.WriteLine("Peso normal: " + imc);
}
else if (imc >= 25f && imc < 29.9f)
{
    Console.WriteLine("Sobre peso: " + imc);
}
else if (imc >= 30f && imc < 34.9f)
{
    Console.WriteLine("Obesidade I: " + imc);
}
else if (imc >= 35f && imc < 39.9f)
{
    Console.WriteLine("Obesidade II: " + imc);
}
else 
{
    Console.WriteLine("Obesidade III: " + imc);
}