using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ElementePare();                      //Problema1
            //Neg_Nul_Poz();                       //Problema2
            //Sum_Prod_n();                        //Problema3
            //PozitiaLui_a();                      //Problema4
            //PozitiaEgalaCuValoarea();            //Problema5
            //Verificare_Ordine_crescatoare();     //Problema6
            //Min_Max();                           //Problema7
            //Fibonacci();                         //Problema8
            //Monoton();                           //Problema9
            //ConsecutiveEgale();                  //Problema10
            //SumaInverselor();                    //Problema11
            //GrupuriConsecutive();                //Problema12
            //CrescatoareRotita();                 //Problema13
            MonotonaRotita();                    //Problema14
        }

        private static void MonotonaRotita()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int k2 = 0;
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            int firstelement = aux;
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x < aux) k++;
                if (x > aux) k2++;
                aux = x;
            }
            if ((k == 1 && firstelement > aux ) || (k2 == 1 && firstelement < aux))
                Console.WriteLine("Este o secventa monotona rotita.");
            else
                Console.WriteLine("Nu este o secventa monotona rotita.");



            
        }

        private static void CrescatoareRotita()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            int firstelement = aux;
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x < aux) k++;
                aux = x;
            }
            if (k == 1 && firstelement > aux)
                Console.WriteLine("Este o secventa crescatoare rotita.");
            else
                Console.WriteLine("Nu este o secventa crescatoare rotita.");
        }

        private static void GrupuriConsecutive()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (aux != 0 && x == 0) k++;
                aux = x;
            }
            Console.WriteLine($"{k} grupuri de numere consecutive diferite de zero sunt");
        }

        private static void SumaInverselor()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("x = ");
                decimal x = int.Parse(Console.ReadLine());
                sum += 1 / x;
            }
            Console.WriteLine($"Suma inverselor acestor numere este: {sum}");
        }

        private static void ConsecutiveEgale()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int max = 1;
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x == aux) k++;
                else k = 1;
                if (k > max) max = k;

                aux = x;
            }
            Console.WriteLine($"{max} este numarul maxim de numere consecutive egale din secventa");
        }

        private static void Monoton()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool crescatoare = true;
            bool descrescatoare = true;
            
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x < aux) crescatoare = false;
                if (x > aux) descrescatoare = false;
                aux = x;
            }
            if (crescatoare || descrescatoare)
                Console.WriteLine("Este MONOTON");
            else
                Console.WriteLine("Nu este monoton.");
        }

        private static void Fibonacci()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int aux;
            for (int i = 2; i <= n; i++)
            {
                aux = f2;
                f2 = f1 + f2;
                f1 = aux;
            }
            Console.WriteLine($"Al {n}-(le)a numar din sirul lui Fibonacci este {f1}.");

        }
        private static void Min_Max()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int min = x;
            int max = x;
            for (int i = 2; i <= n; i++)
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                if (x < min) min = x;
                if (x > max) max = x;
                
            }
            Console.WriteLine($" {min} este cea mai mica valoare din secventa.");
            Console.WriteLine($" {max} este cea mai mare valoare din secventa.");
        }

        private static void Verificare_Ordine_crescatoare()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool suntInOrdineCrescatoare = true;
            Console.Write("x = ");
            int aux = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x < aux) suntInOrdineCrescatoare = false;
                aux = x;
            }
            if (suntInOrdineCrescatoare)
                Console.WriteLine("Sunt in ordine crescatoare.");
            else 
                Console.WriteLine("Nu sunt in ordine crescatoare.");
        }

        private static void PozitiaEgalaCuValoarea()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (i == x) k++;    
            }
            Console.Write($"{k} elemente, din secventa de mai sus, de {n} numere ");
            Console.WriteLine("sunt egale cu pozitia, pe care apar in secventa.");
        }

        private static void PozitiaLui_a()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int poz = -1;

            for (int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (a == x)
                    if (poz == -1) //first occurence test    
                    {               //(without this  line ↑ the poz variable will store the position of last occurence of a)
                        poz = i + 1;
                    }
            }
            Console.WriteLine($"Pozitia numarului {a} este {poz}");
        }

        private static void Sum_Prod_n()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int prod = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                sum += x;
                prod *= x;
            }
            Console.WriteLine($"Suma numerelor este: {sum} ");
            Console.WriteLine($"Produsul numerelor este: {prod} ");
        }

        private static void Neg_Nul_Poz()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int neg = 0;
            int nul = 0;
            int poz = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x < 0) neg++;
                else if (x > 0) poz++;
                else nul++;
            }
            Console.WriteLine($"Secventa de mai sus are: {neg} numere negative,");
            Console.WriteLine($"                         {poz} numere pozitive,");
            Console.WriteLine($"                         {nul} numere nule.");
        }

        private static void ElementePare()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) contor++;
            }
            Console.WriteLine($"In secventa introdusa, sunt {contor} elemente pare.");
        }
    }
}
