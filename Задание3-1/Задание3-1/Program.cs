using System;
namespace task31
{
    class Program
    {
        public static void Main()
        {
            //
            Console.WriteLine("One dimensional array:");
            Console.WriteLine("Enter array length. If you want to enter manually, write true. Otherwise, write false.");
            OneDimensionalArray one = new(int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            one.Print();
            Console.WriteLine($"Average value in array: { one.Average()}");
            one.LessThan100();
            one.UniqueOnly();
            Console.WriteLine("Enter arguments again to refill the array:");
            one.FillAgain(int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            one.Print();

            //
            Console.WriteLine("Two dimensional array:");
            Console.WriteLine("Enter array length. If you want to enter manually, write true. Otherwise, write false.");
            TwoDimensionalArray two = new(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            two.Print();
            Console.WriteLine($"Average value in array: {two.Average()}");
            Console.WriteLine("Enter arguments again to refill the array:");
            two.FillAgain(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            two.EvenReverse();

            //
            Console.WriteLine("Jagged array:");
            Console.WriteLine("Enter array length. If you want to enter manually, write true. Otherwise, write false.");
            JaggedArray jagged = new(int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            jagged.Print();
            Console.WriteLine($"Average value in array: {jagged.AverageOfAll()}");
            Console.WriteLine("Average value in each array:");
            double[] doubles = jagged.InternalAverage();
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write(doubles[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter arguments again to refill the array:");
            jagged.FillAgain(int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            jagged.Print();
        }
    }
    
}

