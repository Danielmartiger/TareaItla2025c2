
int num;
Console.WriteLine("Escribe un numero");
int.TryParse(Console.ReadLine(), out num);

if (num % 2 == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es impar");
}