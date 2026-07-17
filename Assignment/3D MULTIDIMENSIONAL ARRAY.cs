using System;

class Program
{
    static void Main()
    {
        int[,,] arr = new int[2, 2, 2];
        int value = 1;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    arr[i, j, k] = value++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Layer " + i);

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(arr[i, j, k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}