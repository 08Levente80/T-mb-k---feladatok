using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömbök___feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A szint - Alapok (1-9.)

            //1. Feladat
            int[] szamok = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Első elem: " + szamok[0]);
            Console.WriteLine("Harmadik elem: " + szamok[2]);
            Console.WriteLine("Utolsó elem: " + szamok[szamok.Length - 1]);
            Console.WriteLine("Tömb hossza: " + szamok.Length);

            //2. Feladat
            int[] szamok2 = new int[5];

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write((i + 1) + ". szám: ");
                szamok2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(", ", szamok2));

            //3. Feladat
            int[] szamok3 = { 1, 4, 6, 8, 10 };

            for (int i = szamok3.Length - 1; i >= 0; i--)
            {
                Console.Write(szamok3[i] + " ");
            }

            //4. Feladat
            int[] szamok4 = { 1, 2, 3, 4, 5, 6 };

            foreach (int szam in szamok4)
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine(szam + " - páros");
                }
                else
                {
                    Console.WriteLine(szam + " - páratlan");
                }
            }

            //5. Feladat
            int[] szamok5 = { 1, -2, 3, 4, 5 };

            for (int i = 0; i < szamok5.Length; i++)
            {
                szamok5[i] = szamok5[i] * 10;
            }

            Console.WriteLine(string.Join(", ", szamok5));

            //6. Feladat
            int[] szamok6 = { -3, 0, 2, 8, -5 };

            int darab = 0;

            foreach (int szam in szamok6)
            {
                if (szam > 0)
                {
                    darab++;
                }
            }

            Console.WriteLine("Pozitív számok száma: " + darab);

            //7. Feladat
            int[] szamok7 = { 1, 2, 6 };

            int osszeg = 0;

            foreach (int szam in szamok7)
            {
                osszeg += szam;
            }

            Console.WriteLine("Összeg: " + osszeg);

            if (szamok7.Length > 0)
            {
                double atlag = (double)osszeg / szamok7.Length;
                Console.WriteLine("Átlag: " + atlag);
            }
            else
            {
                Console.WriteLine("A tömb üres, nem számítható átlag.");
            }

            //8. Feladat
            int[] szamok8 = { -7, -2, -9, 4, 1 };

            if (szamok8.Length > 0)
            {
                int minimum = szamok8[0];
                int maximum = szamok8[0];

                foreach (int szam in szamok8)
                {
                    if (szam < minimum)
                    {
                        minimum = szam;
                    }

                    if (szam > maximum)
                    {
                        maximum = szam;
                    }
                }

                Console.WriteLine("Minimum: " + minimum);
                Console.WriteLine("Maximum: " + maximum);
            }
            else
            {
                Console.WriteLine("A tömb üres.");
            }

            //9. Feladat
            int[] szamok9 = { 5, 9, 2, 4, 8 };

            for (int i = 0; i < szamok9.Length; i += 2)
            {
                Console.Write(szamok9[i] + " ");
            }



            //B szint - Klasszikus algoritmusok (10-18.)

            //10. Feladat
            int[] szamok10 = { 4, 7, 4, 2, 9 };

            Console.Write("Keresett szám: ");
            int keresett = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < szamok10.Length; i++)
            {
                if (szamok10[i] == keresett)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine("Index: " + index);

            //11. Feladat
            int[] szamok11 = { 4, 7, 4, 2, 9 };

            Console.Write("Keresett szám: ");
            int keresett11 = int.Parse(Console.ReadLine());

            int index11 = -1;

            for (int i = 0; i < szamok11.Length; i++)
            {
                if (szamok11[i] == keresett11)
                {
                    index11 = i;
                }
            }

            Console.WriteLine("Utolsó előfordulás indexe: " + index11);

            //12. Feladat
            int[] szamok12 = { 20, 50, 65, 80, 40, 100 };

            int darab12 = 0;

            foreach (int szam in szamok12)
            {
                if (szam > 50)
                {
                    Console.Write(szam + " ");
                    darab12++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Darabszám: " + darab12);

            //13. Feladat
            int[] szamok13 = { 2, 4, 6 };

            int osszeg13 = 0;

            foreach (int szam in szamok13)
            {
                osszeg13 += szam;
            }

            if (szamok13.Length > 0)
            {
                double atlag = (double)osszeg13 / szamok13.Length;
                int darab13 = 0;

                foreach (int szam in szamok13)
                {
                    if (szam > atlag)
                    {
                        Console.Write(szam + " ");
                        darab13++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Átlagnál nagyobb elemek száma: " + darab13);
            }

            //14. Feladat
            int[] szamok14 = { 1, 2, 3 };

            if (szamok14.Length >= 2)
            {
                int seged = szamok14[0];

                szamok14[0] = szamok14[szamok14.Length - 1];
                szamok14[szamok14.Length - 1] = seged;
            }

            Console.WriteLine(string.Join(", ", szamok14));

            //15. Feladat
            int[] szamok15 = { 7, 7, 3, 2, 9, 9, 5 };

            if (szamok15.Length >= 2)
            {
                int maximum = szamok15[0];
                int masodik = 0;
                bool vanMasodik = false;

                foreach (int szam in szamok15)
                {
                    if (szam > maximum)
                    {
                        masodik = maximum;
                        maximum = szam;
                        vanMasodik = true;
                    }
                    else if (szam < maximum)
                    {
                        if (!vanMasodik || szam > masodik)
                        {
                            masodik = szam;
                            vanMasodik = true;
                        }
                    }
                }

                if (vanMasodik)
                {
                    Console.WriteLine("Második legnagyobb: " + masodik);
                }
                else
                {
                    Console.WriteLine("Nincs két különböző érték.");
                }
            }
            else
            {
                Console.WriteLine("Nincs két különböző érték.");
            }

            //16. Feladat
            int[] szamok16 = { 1, 2, 3, 1 };

            bool vanIsmetlodes = false;

            for (int i = 0; i < szamok16.Length; i++)
            {
                for (int j = i + 1; j < szamok16.Length; j++)
                {
                    if (szamok16[i] == szamok16[j])
                    {
                        vanIsmetlodes = true;
                        break;
                    }
                }

                if (vanIsmetlodes)
                {
                    break;
                }
            }

            if (vanIsmetlodes)
            {
                Console.WriteLine("Van ismétlődő szám.");
            }
            else
            {
                Console.WriteLine("Nincs ismétlődő szám.");
            }

            //17. Feladat
            int[] szamok17 = { 3, 5, 6, 9, 10, 12 };

            int darab17 = 0;

            foreach (int szam in szamok17)
            {
                if (szam % 3 == 0)
                {
                    darab17++;
                }
            }

            int[] eredmeny = new int[darab17];

            int index17 = 0;

            foreach (int szam in szamok17)
            {
                if (szam % 3 == 0)
                {
                    eredmeny[index17] = szam;
                    index17++;
                }
            }

            Console.WriteLine(string.Join(", ", eredmeny));

            //18. Feladat
            int[] szamok18 = { 5, 1, 3, 8, 2 };

            for (int vege = szamok18.Length - 1; vege > 0; vege--)
            {
                for (int i = 0; i < vege; i++)
                {
                    if (szamok18[i] > szamok18[i + 1])
                    {
                        int seged = szamok18[i];

                        szamok18[i] = szamok18[i + 1];
                        szamok18[i + 1] = seged;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", szamok18));

            Console.ReadLine();
        }
    }
}
