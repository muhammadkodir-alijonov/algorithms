/*//class MultiplicationTables //salom dunyo
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Input the numbers (Tables to be calculated) separated by commas (e.g., 2,3,4,5,6,7,8,9,10): ");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(',');

//        foreach (string numberStr in numbers)
//        {
//            if (int.TryParse(numberStr, out int number))
//            {
//                Console.WriteLine($"\nMultiplication Table for {number}:\n");
//                for (int i = 1; i <= 10; i++)
//                {
//                    int result = number * i;
//                    Console.WriteLine($"{number} X {i} = {result}");
//                }
//            }
//            else
//            {
//                Console.WriteLine($"Invalid input: {numberStr} is not a valid number.");
//            }
//        }
//    }
//}

using System;

class MultiplicationTables
{
    static void Main(string[] args)
    {
        Console.WriteLine("Raqamlarni vergul bilan kiriting (masalan, 2,3,4,5,6,7,8,9,10): ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(',');

        for (int i = 1; i <= 10; i++)
        {
            foreach (string numberStr in numbers)
            {
                if (int.TryParse(numberStr, out int number))
                {
                    int result = number * i;
                    Console.Write($"{number} X {i} = {result}\t");
                }
                else
                {
                    Console.WriteLine($"Noto'g'ri kiritish: {numberStr} haqiqiy raqam emas.");
                }
            }
            Console.WriteLine();
        }
    }
}



*//*


using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod();
            Console.ReadKey();
        }

        private static async void SomeMethod()
        {
            int count = 10;
            Console.WriteLine("SomeMethod Method Started");

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(5000);
            //cancellationTokenSource.CancelAfter(5000);
            try
            {
                await LongRunningTask(count, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("\nSomeMethod Method Completed");
        }

        public static async Task LongRunningTask(int count, CancellationToken token)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\nLongRunningTask Started");

            for (int i = 1; i <= count; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("LongRunningTask Processing....");
                if (token.IsCancellationRequested)
                {
                    throw new TaskCanceledException();
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"LongRunningTask Took {stopwatch.ElapsedMilliseconds / 1000.0} Seconds for Processing");
        }
    }
}*//*

// C# program for implementation 
// of Selection Sort
using System;

class GFG
{
    static void sort(int[] arr)
    {
        int n = arr.Length;

        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            // Swap the found minimum element with the first
            // element
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    // Prints the array
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Driver code 
    public static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        sort(arr);
        Console.WriteLine("Sorted array");
        printArray(arr);
    }

}
// This code is contributed by Sam007
*/
//namespace golden
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 2, 5, 8, 9, 12, 16, 23, 38, 56, 72, 91 };
//            int target = 23;

//            int result = BinarySearch(arr, target);

//            if (result != -1)
//            {
//                Console.WriteLine("Target found at index " + result);
//            }
//            else
//            {
//                Console.WriteLine("Target not found in the array");
//            }
//        }
//        //binarysearrch
//        static int BinarySearch(int[] arr, int target)
//        {
//            int left = 0;
//            int right = arr.Length - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (arr[mid] == target)
//                {
//                    return mid; // Found the target at index mid
//                }
//                else if (arr[mid] < target)
//                {
//                    left = mid + 1; // Target is in the right half
//                }
//                else
//                {
//                    right = mid - 1; // Target is in the left half
//                }
//            }

//            return -1; // Target not found
//        }
//    }
//}

/*using System;
namespace ComparisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43,123,1,2,5,3,56};
            BubbleSortAlgorithm(arr);
            Console.WriteLine("Sorted Algo: ");
            foreach (int i in arr) Console.WriteLine(i);
        }
        static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }
    }
}*/
/*using System;
namespace ComparisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 123, 1, 2, 5, 3, 56 };
            InsertionSort(arr);
            Console.WriteLine("Sorted Algo: ");
            foreach (int i in arr) Console.WriteLine(i);
        }
        static void InsertionSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                var currentElement = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > currentElement)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = currentElement;
            }
        }
    }
}
*/

/*using System;
namespace ComparisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 123, 1, 2, 5, 3, 56,132 };
            SelectionSort(arr);
            Console.WriteLine("Sorted Algo: ");
            foreach (int i in arr) Console.WriteLine(i);
        }
        static void SelectionSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                var minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
    }
}*/

