using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Setu_2_fara_vectorii
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul exercitiului(1-17): ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) ex1();
            if (n == 2) ex2();
            if (n == 3) ex3();
            if (n == 4) ex4();
            if (n == 5) ex5();
            if (n == 6) ex6();
            if (n == 7) ex7();
            if (n == 8) ex8();
            if (n == 9) ex9();
            if (n == 10) ex10();
            if (n == 11) ex11();
            if (n == 12) ex12();
            if (n == 13) ex13();
            if (n == 14) ex14();
            if (n == 15) ex15();
            if (n == 16) ex16();
            if (n == 17) ex17();
            if (n > 17 || n < 1) Main();
        }
        static void ex1()
        {
            Console.WriteLine("1.Se da o secventa de n numere si sa se determine cate din ele sunt pare:");
            Console.Write("n = ");
            int s = 0, i = 0, n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            for (i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    s++;
            }
            Console.WriteLine("In secventa de mai sus sunt " + s + " numere pare");
            Main();
        }
        static void ex2()
        {
            Console.WriteLine("2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.Write("n = ");
            int poz = 0, neg = 0, zer = 0, i = 0, n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            for (i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                    poz++;
                if (x < 0)
                    neg++;
                if (x == 0)
                    zer++;
            }
            Console.WriteLine("Sunt: " + poz + " numere pozitive, " + neg + " numere negative, " + zer + " numere nule");
            Main();
        }
        static void ex3()
        {
            Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma = " + n * (n + 1) / 2);
            decimal p = 1;
            for (int i = 1; i < n; i++)
                p *= i;
            Console.WriteLine("Produsul = " + p);
            Main();
        }
        static void ex4()
        {
            Console.WriteLine("4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");

            int a, i = 0, n, x, j = 0 ; 
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");
            
            int steag = 0;
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (a == x)
                {
                    j = i;
                    steag = 1;
                }
            }
            if (steag == 0)
                Console.WriteLine("Numarul " + a + " nu este prezent in sir.(-1)");
            else
                Console.WriteLine(a + " este al " + (i) + " numar");
            Main();
        }
        static void ex5()
        {
            Console.WriteLine("5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.Write("n = ");
            int s = 0, i = 0, n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            for (i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i == x)
                    s++;
            }
            Console.WriteLine(s + " numere sunt egale cu poziti lor");
            Main();
        }
        static void ex6()
        {
            Console.WriteLine("6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.Write("n = ");
            int i, n, steag = 0;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (y > x)
                    steag = 1;
                y = x;
            }
            if (steag == 1)
                Console.WriteLine("Sirul nu este ordonat crescator");
            else
                Console.WriteLine("Sirul este ordonat crescator");
            Main();
        }
        static void ex7()
        {
            Console.WriteLine("7.Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            int n, i, max, min;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            max = int.Parse(Console.ReadLine());
            min = max;
            for (i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }

            Console.WriteLine("Numarul cel mai mare este: " + max);
            Console.WriteLine("Numarul cel mai mic este: " + min);

            Main();
        }
        static void ex8()
        {
            Console.WriteLine("8.Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            int n, x3 = 1, x2 = 1, i, m;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (m = n; m > 4; m--)
            {
                i = x3;
                x3 += x2;
                x2 = i;

            }
            if (n == 1)
                Console.WriteLine("Sirul lui Fibonaci este: f" + n + " = 0");
            else
            {
                if (n == 2 || n == 3)
                    Console.WriteLine("Sirul lui Fibonaci este: f" + n + " = 1");
                else
                    Console.WriteLine("Sirul lui Fibonaci este: f" + n + " = " + (x3 + x2));
            }
            Main();
        }
        static void ex9()
        {
            Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            int n, i, cre = 0, des = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int y = int.Parse(Console.ReadLine());
            int x;
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > y)
                    des = 1;
                if (x < y)
                    cre = 1;
                y = x;
            }
            if (des == 0 && cre == 0)
                Console.WriteLine("Sirul este format dintr-un singur numar");
            else
            {
                if (des == 0)
                    Console.WriteLine("Sirul este descrescator");
                else
                {
                    if (cre == 0)
                        Console.WriteLine("Sirul este crescator");
                    else
                        Console.WriteLine("Sirul nu este monoton");
                }
            }
            Main();
        }
        static void ex10()
        {
            Console.WriteLine("10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
            int n, i, j, s = 1, m;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            for (i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                m = 1;
                for (j = i + 1; j < n; j++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (x == y)
                        m++;
                    else
                        break;
                }
                if (m > s)
                    s = m;
                i = j;
            }
            Console.WriteLine("Numarul maxim de secvente consecutive este: " + s);

            Main();
        }
        static void ex11()
        {
            Console.WriteLine("11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            int n, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            float s = 0;
            for (i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                s = s + (float)1 / x;
            }
            Console.WriteLine("Suma inverseleor este egala cu: " + s);
            Main();
        }
        static void ex12()
        {
            Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            int n, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];
            Console.WriteLine("Introduceti " + n + " numere");

            int s = 0, x = 0, y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            { 
                x = int.Parse(Console.ReadLine());
                if (x == 0 && y != 0)
                    s++;
                y = x;
            }
            if (x != 0)
                s++;
            Console.WriteLine("Sunt " + s + " cuvinte");
            Main();
        }
        static void ex13()
        {
            Console.WriteLine("13.O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            int n, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int steag = 0, y = int.Parse(Console.ReadLine()), x = 0, aux = y;
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (y > x)
                    steag++;
                y = x;
            }
            if (aux < x)
                steag++;
            if (steag <= 1)
                Console.WriteLine("Sirul este o secventa crescatoare rotita");
            else
                Console.WriteLine("Sirul nu este o secventa crescatoare rotita");
            Main();
        }
        static void ex14()
        {
            Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.");
            int n, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int des = 0, cre = 0, x = 0, y = int.Parse(Console.ReadLine()), aux = y;
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (y < x)
                    des++;
                if (y > x)      
                    cre++;
                y = x;
            }

            if (aux > x)
                des++;
            if (aux < x)
                cre++;
            if (des <= 1 && cre <= 1)
                Console.WriteLine("Sirul este o secventa monotona descrescatoare si crescatoare rotita");
            else
            {
                if (des <= 1)
                    Console.WriteLine("Sirul este o secventa monotona descrescatoare rotita");
                else
                {
                    if (cre <= 1)
                        Console.WriteLine("Sirul este o secventa monotona crescatoare rotita");
                    else
                        Console.WriteLine("Sirul nu este o secventa monotona rotita");
                }
            }
            Main();
        }
        static void ex15()
        {
            Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.");
            int n, i, steag = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int x, y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (steag % 2 == 0)
                {
                    if (y > x)
                        steag++;
                }
                else
                {
                    if (y < x)
                        steag++;
                }
                y = x;
            }
            if (steag > 1 || steag == 0)
                Console.WriteLine("Sirul nu este o secventa bitonioca");
            else
                Console.WriteLine("Sirul este o secventa bitonioca");

            Main();
        }
        static void ex16()
        {
            Console.WriteLine("16.O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
            int n, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int steag = 0, y, x, rest = 0;
            y = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            if (y > x)
                rest = 1;
            y = x;
            for (i = 2; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (steag % 2 == rest)
                {
                    if (y > x)
                        steag++;
                }
                else
                {
                    if (y < x)
                        steag++;
                }
                y = x;
            }
            if (steag < 3)
                Console.WriteLine("Sirul este o secventa bitonioca rotita");
            else
                Console.WriteLine("Sirul nu este o secventa bitonioca rotita");
            Main();
        }
        static void ex17()
        {
            Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");
            int n, i;
            Console.Write("Lungimea sirului = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti " + n + " numere");

            int s = 0, max = 0, x;
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    s++;
                else
                    s--;
                if (s > max)
                    max = s;
                if (s < 0)
                    break;
            }
            if (s != 0)
                Console.WriteLine("Secventa nu este corecta");
            else
                Console.WriteLine("Secventa este corecta si are nivelul maxim de incuibare " + max);

            Main();
        }
    }
}

