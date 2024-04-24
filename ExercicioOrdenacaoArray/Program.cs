int[] vetor = new int[5] { 58, 8, 31, 1000, 8 };
int[] vetor2 = vetor;
int aux;

for (int i = 0; i < 5; i++)
{
    for (int j = (i + 1); j < 5; j++)
    {
        if (vetor2[i] > vetor2[j])
        {
            aux = vetor2[i];
            vetor2[i] = vetor2[j];
            vetor2[j] = aux;
        }
    }
}

for (int i = 0; i < 5; i++)
{
    Console.Write(vetor2[i] + " ");
}