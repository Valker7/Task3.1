using System;
namespace task31
{
    public class OneDimensionalArray
    {
        private int n;
        private bool input;
        private int[] array;
        private static Random rand = new Random();

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Length
        {
            get
            {
                return n;
            }
        }

        private void ManualInput()
        {
            Console.WriteLine($"Enter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void RandomInput()
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-200, 200);
            }
        }

        public OneDimensionalArray(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new int[n];


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
            Console.Write("Printed array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }


        public double Average()
        {

            double summ = 0;
            for (int i = 0; i < n; i++)
            {
                summ += array[i];
            }
            return summ / n;

        }


        public void LessThan100()
        {
            int n1 = n;
            foreach (int elem in array)
            {
                if (Math.Abs(elem) > 100)
                {
                    n1--;
                }
            }
            int[] array1 = new int[n1];
            int i1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    array1[i1] = array[i];

                    i1++;
                }
            }
            Console.Write("Printed array without elements that are greater than 100: ");
            for (int i = 0; i < n1; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
        }


        public void UniqueOnly()
        {
            Console.Write("Printed array without duplicates: ");
            int n1 = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        n1--;
                        break;
                    }
                }
            }
            int[] array1 = new int[n1];
            int i1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (!array1.Contains(array[i]))
                {
                    array1[i1] = array[i];
                    i1++;
                }

            }
            for (int i = 0; i < n1; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
        }


        public void FillAgain(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new int[n];


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
