using System;

namespace Polinom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите число");
            string mass1 = Console.ReadLine();
            string[] a = mass1.Split(",");
        
            for (int i = 0; i < a.Length; i++)
            {
                string FirstLine = a[i];
                if (FirstLine != a[a.Length-1-i])
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
           

            }

        }
    }
}
