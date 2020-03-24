using System;

namespace LEct_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }
        public void Task1() 
        {
            type[] variable_name = new type[length];

        }

        static void Task3()
        {
            int[] arr = new int[13];
            Random rnd = new Random();
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) 
            {

                Console.WriteLine(Generate(rnd));
                if (arr[i] > max)
                {
                   
                    max = arr[i];
                }
                Console.WriteLine(max);

            }

        static Double  Generate(Random rnd) 
            {
                return rnd.Next(10);

            }
        
        }
    }
}
