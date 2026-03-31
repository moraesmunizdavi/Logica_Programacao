int n;
long fat = 1;
Console.WriteLine("Entre com o Fatorial:");
n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++) 
{
    fat = fat * i;
}
Console.WriteLine("Fatorial de " + n + "=" + fat);