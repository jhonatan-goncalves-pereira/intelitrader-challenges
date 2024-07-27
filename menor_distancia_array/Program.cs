using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array1 = {-1, 5, 13, 8, 17, 20, 25, 11, 4, 3};
        int[] array2 = {26, 6, 15, 10, 7, 2, 19, 22, 9, 14};

        int minDistance = int.MaxValue;

        foreach (int num1 in array1)
        {
            foreach (int num2 in array2)
            {
                int distance = Math.Abs(num1 - num2);
                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }
        }

        Console.WriteLine("A distância mínima é: " + minDistance);
    }
}
