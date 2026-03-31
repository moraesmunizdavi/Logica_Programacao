int n = 10;
Double soma = 0;
Double preco;

for (int i = 0; i < n; i=+1);
{
    Console.Write("Entre com o preço:");
     preco= Double.Parse(Console.ReadLine());
    soma = soma + preco;
}
Console.WriteLine("Soma:"+soma);
Double media = soma / n;
Console.WriteLine("Preço Médio:"+media);  