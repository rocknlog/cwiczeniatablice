using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = WygenerujTablice(10); 

        Console.WriteLine("Tablica przed odwróceniem:");
        WypiszTablice(tablica);

        OdwrocTablice(tablica);

        Console.WriteLine("Tablica po odwróceniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static int[] WygenerujTablice(int rozmiar)
    {
        int[] tablica = new int[rozmiar];
        Random rand = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(1, 100); 
        }

        return tablica;
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static void OdwrocTablice(int[] tablica)
    {
        int lewy = 0;
        int prawy = tablica.Length - 1;

        while (lewy < prawy)
        {
           
            int temp = tablica[lewy];
            tablica[lewy] = tablica[prawy];
            tablica[prawy] = temp;

            lewy++;
            prawy--;
        }
    }
}

