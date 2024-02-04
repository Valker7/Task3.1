using System;
namespace task31
{
    public class JaggedArray
    {
        private int n;
        private bool input;
        private OneDimensionalArray[] array;
        private static Random rand = new Random();

        private void ManualInput()
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array length:");
                OneDimensionalArray one = new(int.Parse(Console.ReadLine()), true);
                array[i] = one;
                 
            }

        }

        private void RandomInput()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array length:");
                OneDimensionalArray one = new(int.Parse(Console.ReadLine()), false);
                array[i] = one;
            }
        }


        public JaggedArray(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new OneDimensionalArray[n];


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
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
                
        }


        


        public double AverageOfAll()
        {
            double summ = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summ += array[i][j];
                    count++;
                }
                

            }
            return summ / count;

        }


        public double[] InternalAverage()
        {
            double[] averarray = new double[n];
            for (int i = 0; i < n; i++)
            {
                averarray[i] = array[i].Average();
            }
            return averarray;
        }




        public void FillAgain(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new OneDimensionalArray[n];


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
