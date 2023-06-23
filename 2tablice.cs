using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        int[] tablica = new int[rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            Console.Write("Podaj element {0}: ", i + 1);
            tablica[i] = Convert.ToInt32(Console.ReadLine());
        }

        int najmniejszy = ZnajdzNajmniejszyElement(tablica);
        int najwiekszy = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);

        Console.ReadLine();
    }

    static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        return najwiekszy;
    }
}
