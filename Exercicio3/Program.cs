float nota1;
float nota2;
float nota3;
float nota4;

Console.WriteLine("Digite a nota do aluno no primeiro bimestre: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do aluno no segundo bimestre: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do aluno no terceiro bimestre: ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do aluno no quarto bimestre: ");
nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2  + nota3 + nota4) / 4;

if(media >= 7)
{
    Console.WriteLine($"Media do aluno: {media:F2} ");
    Console.WriteLine("Aluno aprovado");
} else if(media >= 5.1 || media <= 6.9)
{
    Console.WriteLine($"Media do aluno: {media:F2} ");
    Console.WriteLine("Aluno em recuperação");
}
else
{
    Console.WriteLine($"Media do aluno: {media:F2} ");
    Console.WriteLine("Aluno reprovado");
}