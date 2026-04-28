int[] nota=new int[5];

Random rnd=new Random();
for(int i=0; i<nota.Length; i++)
{
    int num=rnd.Next(0,11);
    nota[i]=1+num;
}

for(int i=0; i<nota.Length; i++)
{
    Console.WriteLine("Índice "+i+":"+nota[i]);
}

int soma=0;
for (int i = 0; i < nota.Length; i++)
{
    soma = soma + nota[i];
}

int media=soma/nota.Length;
Console.WriteLine("A média da prova é: "+media);

// Solução Particular
int maior = 0;
for (int i = 0; i < nota.Length; i++)
{
    if (nota[i] > maior)
    {
        maior = nota[i];
    }
}
Console.WriteLine("A maior nota da prova é: "+maior);

// Solução Genérica
maior=  nota[0];
for (int i = 0; i < nota.Length; i++)
{
    if (nota[i] > maior)
    {
        maior = nota[i];
    }
}
Console.WriteLine("A maior nota da prova é: " + maior);