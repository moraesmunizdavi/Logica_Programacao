Console.Write("Entre com a Quantidade de Números:");
int n = 10;
int soma = 0;
n=int.Parse(Console.ReadLine()); 
for (int i = 0; i <= n; i++)
{
    soma += 1;
}
Console.WriteLine("Soma:" + soma);