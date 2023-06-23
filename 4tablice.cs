using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 5, 3, 9, 1, 7, 2, 6, 8, 4 }; 

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int aktualnyElement = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > aktualnyElement)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = aktualnyElement;
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
