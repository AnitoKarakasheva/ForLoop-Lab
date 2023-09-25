using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddsum = 0;
            int evensum = 0;
            for (int i = 0; i < n; i++)
            {
                int newNumber =int.Parse(Console.ReadLine());
                if (i % 2 ==0)
                {
                    evensum = evensum + newNumber;
                }
                else
                {
                    oddsum=oddsum+ newNumber;
                }
                if (evensum==oddsum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + oddsum);
                }
                else
                {
                    int diff = Math.Abs(oddsum - evensum);
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + diff);
                }
            }
        }
    }
}
