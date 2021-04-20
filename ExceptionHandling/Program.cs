using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(2,3));
        }
    }
    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public decimal Bol(int sayi1, int sayi2)
        {

            return sayi1 / sayi2;
        }
    }
}
