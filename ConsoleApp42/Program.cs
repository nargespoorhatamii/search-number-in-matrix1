using System;

namespace Proggram
{
    class test
    {
        public static void Main()
        {
            int[,] matrix = new int[3, 3];

            int counter = 0; //counter for count
            Console.WriteLine("inter nine number");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            } //you need to describe matrix twice 
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine()); //after call a first matrix code you need to conver
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (matrix[i, j] == number)
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);

        }
    }

}