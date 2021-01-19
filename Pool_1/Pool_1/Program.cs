using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EcuatieGrad1();                   //Problema  1 
            //EcuatieGrad2();                   //Problema  2
            //N_SeDivideCuK();                  //Problema  3
            //EsteAnBisect();                   //Problema  4
            //ExtragereCifra();                 //Problema  5
            //PoateFiTriunghiSauNu();           //Problema  6
            //Swap();                           //Problema  7
            //SwapRestrictionat();              //Problema  8   
            //Divizori_n();                     //Problema  9   
            //TestDePrimalitate();              //Problema 10   
            //AfisareCifreOrdineInversa();      //Problema 11   
            //CateDivizoriSuntInInterval();     //Problema 12   
            //CateAniBisectiSuntIntreAnii();    //Problema 13   
            //EstePalindrom();                  //Problema 14   
            //OrdCrescatoare_3Numere();         //Problema 15   
            //OrdCrescatoare_5Numere();         //Problema 16   
            //Euclid();                         //Problema 17   
            //Descompunere_In_Factori_Primi();  //Problema 18   
            //Doar_2_Numere();                  //Problema 19  
            //AfisareFractie();                 //Problema 20 
            Ghicitor_de_numere();             //Problema 21
        }

        private static void Ghicitor_de_numere()
        {
            Random rnd = new Random();
            int nrDeGhicit = rnd.Next(1, 1025);
            int x;
            int nrIncercari = 0;
            do
            {
                Console.Write("Numarul este mai mare sau egal decat ");
                x = int.Parse(Console.ReadLine());
                nrIncercari++;
                if (nrDeGhicit >= x)
                    Console.WriteLine("DA");
                else Console.WriteLine("NU");
            } while (nrDeGhicit != x);
            Console.WriteLine($"Ai ghicit numarul din {nrIncercari} incercari.");
        }

        private static void AfisareFractie()
        {

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // aducem fractia la forma ireductibila.

            Simplificare_La_Ireductibil(ref m,ref n);

            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        private static void Simplificare_La_Ireductibil(ref int m, ref int n)
        {
            for (int div = 2; div < n; div++)
            {
                while (m % div == 0 && n % div == 0)
                {
                    m /= div;
                    n /= div;
                }
            }
        }

        private static void Doar_2_Numere()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x;
            int nrcifre = 0;
            bool contineCifra_i;
            for (int i = 0; i <= 9; i++)
            {
                contineCifra_i = false;
                x = n;
                while (x != 0)
                {
                    if (x % 10 == i)
                    {
                        contineCifra_i = true;
                    }
                    x /= 10;
                }
                if (contineCifra_i)
                {
                    nrcifre++;
                }
            }
            if (nrcifre <= 2)
            {
                Console.WriteLine($" Numarul este format doar din {nrcifre} cifre diferite. Numarul respecta conditiile.");
            }
            else
            {
                Console.WriteLine($" Numarul NU este format doar din 2 cifre diferite, asadar NU respecta conditiile.");
            }
        }

        private static void Descompunere_In_Factori_Primi()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int divPrim = 2;
            int putere;
            while (n != 1)
            {
                
                if (n % divPrim == 0)
                {
                    putere = 0;
                    while (n % divPrim == 0)
                    {
                        putere++;
                        n /= divPrim;
                    }
                    Console.Write($"{divPrim}^{putere}");
                    if (n != 1)
                    {
                        Console.Write(" x ");
                    }
                }
                divPrim++;
            }
            Console.WriteLine();
        }

        private static void Euclid()
        {
            int a, b,aux;
            Console.Write("a:"); a = int.Parse(Console.ReadLine());
            Console.Write("b:"); b = int.Parse(Console.ReadLine());
            while ( a % b != 0)
            {
                aux = a;
                a = b; 
                b = aux % b;
            }
            Console.WriteLine($"Cel mai mare divizor comun este {b}");
        }

        private static void OrdCrescatoare_5Numere()
        {
            int a, b, c, d, e, aux;
            
            Console.Write("a:"); a = int.Parse(Console.ReadLine());
            Console.Write("b:"); b = int.Parse(Console.ReadLine());
            Console.Write("c:"); c = int.Parse(Console.ReadLine());
            Console.Write("d:"); d = int.Parse(Console.ReadLine());
            Console.Write("e:"); e = int.Parse(Console.ReadLine());
            do
            {
                aux = 0;
                if (a > b)
                {
                    aux = a; a = b; b = aux;
                }
                if (b > c)
                {
                    aux = b; b = c; c = aux;
                }
                if (c > d)
                {
                    aux = c; c = d; d = aux;
                }
                if (d > e)
                {
                    aux = d; d = e; e = aux;
                } 
            } while (aux!=0);
            Console.WriteLine($"{a} {b} {c} {d} {e}");
            
        }

        private static void OrdCrescatoare_3Numere()
        {
            int a, b, c, min, max;

            Console.Write("a:"); a = int.Parse(Console.ReadLine());
            Console.Write("b:"); b = int.Parse(Console.ReadLine());
            Console.Write("c:"); c = int.Parse(Console.ReadLine());
            if (a<b)
            {
                min = a; max = b;
            }
            else
            {
                min = b;max = a;
            }
            if (c<min)Console.WriteLine($"{c} {min} {max}");
            else if (c > max) Console.WriteLine($"{min} {max} {c}");
            else Console.WriteLine($"{min} {c} {max}");
        }

        private static void EstePalindrom()
        {
            int n, aux, n2 = 0;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            aux = n;
            while (aux != 0)
            {
                n2 = n2 * 10 + aux % 10;
                aux /= 10;
            }
            if (n == n2) Console.WriteLine($"{n} este palindrom");
            else Console.WriteLine($"{n} NU este palindrom");
             
            Console.WriteLine();
        }

        private static void CateAniBisectiSuntIntreAnii()
        {
            int y1, y2, s = 0;
            Console.Write("y1="); y1 = int.Parse(Console.ReadLine());
            do{ Console.Write("y2="); y2 = int.Parse(Console.ReadLine());} while (y1>y2);

            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    s++;
                }
            }
            Console.Write($"Sunt {s} ani bisecti intre anul {y1} si anul {y2} ");
        }

        private static void CateDivizoriSuntInInterval()
        {
            int n,a,b,s=0;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write("a="); a = int.Parse(Console.ReadLine());
            do { Console.Write("b="); b = int.Parse(Console.ReadLine()); } while (a>b);
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    s++;
                }
            }
            Console.Write($"Sunt {s} numere divizibile cu {n} in intervalul [{a},{b}] ");
            Console.WriteLine();
        }

        private static void AfisareCifreOrdineInversa()
        {
            int n;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                Console.Write($"{ n % 10} ");
                n /= 10;
            }
            Console.WriteLine();
        }

        private static void TestDePrimalitate()
        {
            int n;
            bool prim = true;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                   prim = false;break;
                }
            }
            if (prim) Console.WriteLine($"{n} este un numar prim");
            else Console.WriteLine($"{n} NU este un numar prim");
        }

        private static void Divizori_n()
        {
            int n;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii numarului {n} sunt: ");
            for (int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private static void SwapRestrictionat()
        {
            int a, b;
            Console.Write("a:"); a = int.Parse(Console.ReadLine());
            Console.Write("b:"); b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Inainte de inversare: a = {a} iar b = {b}");
            a += b; b = a - b; a -= b;
            Console.WriteLine($"Dupa inversare: a = {a} iar b = {b}");
        }

        private static void Swap()
        {
            int a, b, aux;
            Console.Write("a:"); a = int.Parse(Console.ReadLine());
            Console.Write("b:"); b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Inainte de inversare: a = {a} iar b = {b}");
            aux = a; a = b; b = aux;
            Console.WriteLine($"Dupa inversare: a = {a} iar b = {b}");
        }

        private static void PoateFiTriunghiSauNu()
        {
            double a, b, c;

            Console.Write("a:"); a = double.Parse(Console.ReadLine());
            Console.Write("b:"); b = double.Parse(Console.ReadLine());
            Console.Write("c:"); c = double.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b )
            {
                Console.WriteLine($"{a}, {b} si {c} pot fi laturile unui triunghi. ");
            }
            else
            {
                Console.WriteLine($"{a}, {b} si {c} NU pot fi laturile unui triunghi. ");
            }
        }

        private static void ExtragereCifra()
        {
            string line;
            int n, k,i;
            Console.Write("n="); 
            line = Console.ReadLine();
            n = int.Parse(line);
            do {Console.Write("k="); k = int.Parse(Console.ReadLine()); } while (k>line.Length);
            i = 0;
            while (n != 0)
            {
                i++;
                if (i==k)
                {
                    Console.WriteLine(n%10);
                }
                n /= 10;
            }
        }

        private static void EsteAnBisect()
        {
            int y;
            Console.Write("y="); y = int.Parse(Console.ReadLine());
            
            if ((y % 4 == 0 && y % 100!=0) || y % 400 == 0)
            {
                Console.WriteLine($"{y} este an bisect");
            }
            else
            {
                Console.WriteLine($"{y} NU este an bisect");
            }
        }

        private static void N_SeDivideCuK()
        {
            int n, k;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write("k="); k = int.Parse(Console.ReadLine());
            if (n%k==0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} NU se divide cu {k}");
            }
        }

        private static void EcuatieGrad2()
        {
            double a, b, c, x1, x2, Delta;

            Console.Write("a:"); a = double.Parse(Console.ReadLine());
            Console.Write("b:"); b = double.Parse(Console.ReadLine());
            Console.Write("c:"); c = double.Parse(Console.ReadLine());
            Console.Write($"{a}x²");
            if (b>=0) Console.Write($"+");
            Console.Write($"{b}x"); 
            if (c>=0) Console.Write($"+");
            Console.WriteLine($"{c}=0");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("x ∈ R  (x apartine lui R)");
                    }
                    else Console.WriteLine("nu exista");
                }
                else
                {
                    x1 = -b / a;
                    Console.WriteLine(x1);
                }

            }
            else
            {
                Delta = b * b - 4 * a * c;
                if (Delta < 0)
                {
                    Console.WriteLine("Nu are radacina in R");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(Delta))/2*a;
                    x2 = (-b - Math.Sqrt(Delta))/2*a;
                    Console.WriteLine($"Radacinile sunt: {x1} , {x2}");
                }
            }
        }

        private static void EcuatieGrad1()
        {
            double a, b, x;
            Console.Write("a:"); a = double.Parse(Console.ReadLine());
            Console.Write("b:"); b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("x ∈ R  (x apartine lui R)");
                else Console.WriteLine("nu exista");
            }
            else
            {
                x = -b / a;
                Console.WriteLine(x);
            }
        }
    }
}
