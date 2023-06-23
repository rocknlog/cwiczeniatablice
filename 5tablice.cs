using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 5, 3, 9, 1, 7, 2, 6, 8, 4 }; // Przykładowa tablica

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWybieranie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minimalnyIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[minimalnyIndex])
                {
                    minimalnyIndex = j;
                }
            }

            if (minimalnyIndex != i)
            {
                int temp = tablica[i];
                tablica[i] = tablica[minimalnyIndex];
                tablica[minimalnyIndex] = temp;
            }
        }
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
