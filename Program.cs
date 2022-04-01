int n;

Console.WriteLine("Digite um número, por favor");
n = Convert.ToInt32(Console.ReadLine());

bool N2 = (n<0);

if (N2)
{
    Console.WriteLine($"{n} é um número negativo");
}
else 
{
    Console.WriteLine();
}
