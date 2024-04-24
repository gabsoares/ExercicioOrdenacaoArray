int[] vetor = new int[5] { 100, 300, 15000, 8, 1 };
int[] vetor2 = vetor;
int[] vetor3 = vetor2;
int aux;

//Ordem crescente
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

//Ordem decrescente
//for (int i = 0; i < 5; i++)
//{
//    for (int j = (i + 1); j < 5; j++)
//    {
//        if (vetor3[i] < vetor3[j])
//        {
//            aux = vetor2[i];
//            vetor2[i] = vetor2[j];
//            vetor2[j] = aux;
//        }
//    }
//}

for (int i = 0; i < 5; i++)
{
    Console.Write(vetor2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.Write(vetor3[i] + " ");
}