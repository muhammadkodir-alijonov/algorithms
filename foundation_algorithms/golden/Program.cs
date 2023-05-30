namespace golden
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 9, 12, 16, 23, 38, 56, 72, 91 };
            int target = 23;

            int result = BinarySearch(arr, target);

            if (result != -1)
            {
                Console.WriteLine("Target found at index " + result);
            }
            else
            {
                Console.WriteLine("Target not found in the array");
            }
        }
        //binarysearrch
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid; // Found the target at index mid
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Target is in the right half
                }
                else
                {
                    right = mid - 1; // Target is in the left half
                }
            }

            return -1; // Target not found
        }
    }
}