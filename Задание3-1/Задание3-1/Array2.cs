using System;
namespace task31
{
    public class TwoDimensionalArray
    {
        private int n;
        private int m;
        private bool input;
        private int[,] array;
        private static Random rand = new Random();

        private void ManualInput()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void RandomInput()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }
        }

        public TwoDimensionalArray(int n, int m, bool input = false)
        {
            this.n = n;
            this.m = m;
            this.input = input;
            array = new int[n,m];


            if (input)
            {
                ManualInput();
            }
            else
            {
                RandomInput();
            }
        }


        public void Print()
        {
            Console.WriteLine("Printed array: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
                
        }


        public void EvenReverse()
        {
            Console.WriteLine("Snake-like printed array: ");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = m-1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {

                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


        public double Average()
        {
            double summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    summ += array[i, j];
                }

            }
            return summ / (n * m);

        }




        public void FillAgain(int n, int m, bool input = false)
        {
            this.n = n;
            this.m = m;
            this.input = input;
            array = new int[n,m];


            if (input)
            {
                ManualInput();
            }
            else
            {
                RandomInput();
            }
        }
        
    }
}
