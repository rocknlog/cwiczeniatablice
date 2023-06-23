using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 5, 3, 9, 1, 7, 2, 6, 8, 4 }; 

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        for (int i = 0; i < n - 1; i++)
        {
            zamiana = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    // Zamiana miejscami elementów
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;

                    zamiana = true;
                }
            }

            
            if (!zamiana)
            {
                break;
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
