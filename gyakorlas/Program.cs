using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Szám kitalálós játék: 1"); //Funkció előhívás
                Console.WriteLine("Számológép: 2");
                int kivalasztas = int.Parse(Console.ReadLine());
                if(kivalasztas == 1)
                {
                    kitalalos();
                }
                if (kivalasztas == 2)
                {
                    szamologep();
                }             
            }
            catch
            {
                Console.WriteLine("Számot kell megadni.");
            }
            // 1. Számológép, 2. Szám kitalálós
            void kitalalos()
            {
                Random veletlen = new Random();
                int szam = veletlen.Next(1, 20);
                int probalkozasok = 0;
                for (int i = 0; i < 99; i++)
                {
                    Console.WriteLine("Tippelj a számra.");
                    int tipp = int.Parse(Console.ReadLine());
                    probalkozasok++;
                    if (szam - 5 == tipp || szam - 4 == tipp || szam - 3 == tipp || szam + 5 == tipp || szam + 4 == tipp || szam + 3 == tipp)
                    {
                        Console.WriteLine("Közel vagy.");
                    }
                    if (szam - 2 == tipp || szam - 1 == tipp || szam + 2 == tipp || szam + 1 == tipp)
                    {
                        Console.WriteLine("Nagyon közel.");
                    }
                    if (szam - 6 == tipp || szam - 7 == tipp || szam - 8 == tipp || szam + 6 == tipp || szam + 7 == tipp || szam + 8 == tipp)
                    {
                        Console.WriteLine("Még messze!");
                    }
                    if (probalkozasok == 6)
                    {
                        Console.WriteLine("Game over");
                        break;
                    }
                    if (tipp == szam)
                    {
                        Console.WriteLine("Meglett!");
                        break;
                    }
                    if(tipp > 20)
                    {
                        Console.WriteLine("A szám 1 és 20 közötti.");
                        probalkozasok--;
                    }
                    Console.WriteLine("A 6-ból ennyi próbálkozást használtál el: " + probalkozasok);
                }
            }
            void szamologep()
            {
                Console.WriteLine("Számológép.");
                try
                {               
                    Console.WriteLine("Kérem az első számot: ");
                    double elso_szam = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Kérem a műveletet: +,-,/,%,*");
                    char karakter = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Kérem a második számot: {0}", elso_szam + " " + " " + karakter + " ?");
                    double masodik_szam =Convert.ToDouble(Console.ReadLine());
                    double eredmeny;
                    if(karakter == '+')
                    {
                        Console.WriteLine("Összeadás.");
                        eredmeny = elso_szam + masodik_szam;
                        Console.WriteLine(elso_szam + " " + karakter + " " + masodik_szam + " Végeredmény: {0}", eredmeny);
                    }
                    if(karakter == '-')
                    {
                        Console.WriteLine("Kivonás");
                        eredmeny = elso_szam - masodik_szam;
                        Console.WriteLine(elso_szam + " " + karakter + " " + masodik_szam + " Végeredmény: {0}", eredmeny);
                    }
                    if(karakter == '/')
                    {
                        Console.WriteLine("Osztás");
                        eredmeny = elso_szam / masodik_szam;
                        Console.WriteLine(elso_szam+" "+karakter+" "+masodik_szam+" Végeredmény: {0:0.00}",eredmeny);
                    }
                    if(karakter == '*')
                    {
                        Console.WriteLine("Szorzás");
                        eredmeny = elso_szam * masodik_szam;
                        Console.WriteLine(elso_szam + " " + karakter + " " + masodik_szam + " Végeredmény: {0}", eredmeny);
                    }
                    if(karakter == '%')
                    {
                        Console.WriteLine("Maradékos osztás");
                        eredmeny = elso_szam % masodik_szam;
                        Console.WriteLine(elso_szam + " " + karakter + " " + masodik_szam + " Végeredmény: {0}", eredmeny);
                    }
                }
                catch
                {
                    Console.WriteLine("^ Helytelen bevitel.");
                }
            }
            Console.ReadKey();
        }
    }
}
