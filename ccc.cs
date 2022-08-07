using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 7, 8, 9 };
            Console.WriteLine(MinMaX(arr,num));
        }
        static void MinMaX (int[] arr,int num)
        {
            
            int mini = 0;
            int maxi = 0;
            for (int i = 0; i <num.Length; i++)
            {
                if (arr[i]<mini)
                {
                    mini = i;
                }

            }
            
        }
    }
}
