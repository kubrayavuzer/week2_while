using System;



class Program
{
    static void Main(string[] args)
    {
        // "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajını 10 kere yazdırma

        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            count++;
        }
        Console.WriteLine("-----------------------------------------------------");

        //1-20 arasındaki sayıları yazdır

        int number = 0;
        while (number < 20)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("----------------------------------------------------");

        //1 ile 20 arasındaki çift sayıları yazdırma

        int evennumber = 0;
        while (evennumber < 20)
        {
            if (evennumber % 2 == 0)
            {
                Console.WriteLine(evennumber);
            }

            evennumber++;
        }

        Console.WriteLine("---------------------------------------------------------");

        //50-150 arasındaki sayıların toplamını yaz

        int sum = 0;
        int total = 50;
        while (total < 150)
        {
            sum += total;
            total++;
        }

        Console.WriteLine("50-150 arasındaki sayıların toplamı: " + sum);

        Console.WriteLine("-----------------------------------------------------------");

        //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı yazdırma

        int sumOdd = 0;
        int sumEven = 0;
        int k = 1;

        while (k < 120);
        {
            if ( k % 2 == 0)
            {
                sumEven++;
            }

            else
            {
                sumOdd++;
            }

            Console.WriteLine($"Çift sayıların toplamı {sumEven}");
            Console.WriteLine($"Tek sayıların toplamı {sumOdd}");

        }

    }


}