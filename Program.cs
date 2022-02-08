// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo ci = CultureInfo.InvariantCulture;

int n, negativo;

Console.Write("Qual a ordem da matriz? ");
n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write("Elemento [" + i + "," + j + "]: ");
        mat[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nDIAGONAL PRINCIPAL: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i,i] + " ");
}

negativo = 0;
for (int i = 0;i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (mat[i,j] < 0)
        {
            negativo++;
        }
    }
}

Console.WriteLine("\nQUANTIDADE DE NEGATIVOS = " + negativo);

