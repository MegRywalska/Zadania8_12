using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania8_12
{
    internal class Zadania
    {
        /*Napisać program wczytujacy ciąg ciag (1<=ciag<=1000) liczb całkowitych i wypisujacy na ekranie najmniesza i najwieksza wczytana liczbę. */
        public static void Zadanie8()
        {
            Console.WriteLine("Podaj ciag liczb (oddzielonych spacja):");
            string[] ciag = Console.ReadLine().Split();

            if (ciag.Length < 1 || ciag.Length > 1000)
            {
                Console.WriteLine("Bledna dlugosc ciągu. Ciag musi byc dluszy niz 1 i krotrzy niz 1000 elementow.");
                return;
            }

            int[] ciagLiczb = new int[ciag.Length];

            for (int i = 0; i < ciag.Length; i++)
            {
                if (!int.TryParse(ciag[i], out ciagLiczb[i]))
                {
                    Console.WriteLine($"Blad podczas konwersji elementu {i + 1} na liczbe ");
                    return;
                }
            }

            int min = ciagLiczb[0];
            int max = ciagLiczb[0];

            for (int i = 1; i < ciagLiczb.Length; i++)
            {
                if (ciagLiczb[i] < min)
                    min = ciagLiczb[i];

                if (ciagLiczb[i] > max)
                    max = ciagLiczb[i];
            }

            Console.WriteLine($"Najmniejsza liczba: {min}");
            Console.WriteLine($"Najwieksza liczba: {max}");
        }

        /*Napisać program wczytujacy ciąg ciag (1<=ciag<=1000) liczb całkowitych i wypisujacy na ekranie wszystkie przyste ciagLiczb w kolejnosci 
         niemalejącej. Do wypisywania elementów użyj pętli foreach*/

        public static void Zadanie9()
        {
            Console.WriteLine("Podaj ciag liczb (oddzielonych spacja):");
            string[] ciag = Console.ReadLine().Split();

            if (ciag.Length < 1 || ciag.Length > 1000)
            {
                Console.WriteLine("Bledna dlugosc ciągu. Ciag musi byc dluszy niz 1 i krotrzy niz 1000 elementow.");
                return;
            }

            int[] ciagLiczb = new int[ciag.Length];

            for (int i = 0; i < ciag.Length; i++)
            {
                if (!int.TryParse(ciag[i], out ciagLiczb[i]))
                {
                    Console.WriteLine($"Blad podczas konwersji elementu {i + 1} na liczbe ");
                    return;
                }
            }

            Array.Sort(ciagLiczb);
            Console.WriteLine("Parzyste ciagu  w kolejności niemalejacej:");

            foreach (int liczba in ciagLiczb)
            {
                if (liczba % 2 == 0)
                {
                    Console.Write($"{liczba} ");
                }
            }

            Console.WriteLine();
        }

        /*Napisać program wczytujacy ciąg ciag (1<=ciag<=1000) liczb całkowitych i wypisujacy na ekranie sume kwadratów wczytanych liczb */

        public static void Zadanie10()
        {
            Console.WriteLine("Podaj ciag liczb (oddzielonych spacja):");
            string[] ciag = Console.ReadLine().Split();


            if (ciag.Length < 1 || ciag.Length > 1000)
            {
                Console.WriteLine("Bledna dlugosc ciągu. Ciag musi byc dluszy niz 1 i krotrzy niz 1000 elementow.");
                return;
            }

            int[] ciagLiczb = new int[ciag.Length];

            for (int i = 0; i < ciag.Length; i++)
            {
                if (int.TryParse(ciag[i], out int liczba))
                {
                    ciagLiczb[i] = liczba;
                }
                else
                {
                    Console.WriteLine($"Blad podczas konwersji elementu {i + 1} na liczbe ");
                    return;
                }
            }

            int sumaKwadratow = 0;
            for (int i = 0; i < ciagLiczb.Length; i++)
            {
                sumaKwadratow += ciagLiczb[i] * ciagLiczb[i];
            }

            Console.WriteLine("Suma kwadratow wczytanych liczb wynosi: " + sumaKwadratow);
        }

        /*Napisać program wczytujacy ciąg ciag (1<=ciag<=1000) liczb całkowitych i wypisujacy na ekranie ile 
         liczb jest dodatnich ujemnych i równych zero*/

        public static void Zadanie11()
        {
            Console.WriteLine("Podaj ciag liczb (oddzielonych spacja):");
            string[] ciag = Console.ReadLine().Split();


            if (ciag.Length < 1 || ciag.Length > 1000)
            {
                Console.WriteLine("Bledna dlugosc ciągu. Ciag musi byc dluszy niz 1 i krotrzy niz 1000 elementow.");
                return;
            }

            int dodatnie = 0;
            int ujemne = 0;
            int zera = 0;

            for (int i = 0; i < ciag.Length; i++)
            {
                if (int.TryParse(ciag[i], out int liczba))
                {
                    if (liczba > 0)
                    {
                        dodatnie++;
                    }
                    else if (liczba < 0)
                    {
                        ujemne++;
                    }
                    else
                    {
                        zera++;
                    }
                }
                else
                {
                    Console.WriteLine($"Blad podczas konwersji elementu {i + 1} na liczbe .");
                    return;
                }
            }

            Console.WriteLine($"Liczby dodatnie: {dodatnie}");
            Console.WriteLine($"Liczby ujemne: {ujemne}");
            Console.WriteLine($"Liczby rowna zero: {zera}");
        }

        /*Wczytaj liczbę naturalna n i wypisz na ekranie tą liczbe w systemie ósemkowym. */

        public static void Zadanie12()
        {
            Console.Write("Podaj liczbę calkowita: ");
            if (int.TryParse(Console.ReadLine(), out int liczba))
            {
                string liczbaOsemkowa = Convert.ToString(Math.Abs(liczba), 8);
                Console.WriteLine($"Liczba {liczba} w systemie osemkowym: {liczbaOsemkowa}");
            }
            else
            {
                Console.WriteLine("Podano nieprawidlowa liczbę calkowita.");
            }
        }

    }
}
