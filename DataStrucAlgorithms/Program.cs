using System;

namespace DataStrucAlgorithms
{
    public class Program
    {
        public static int BinarySearch_Word(string[] arr, string SearchItem)
        {
            int Start = 0;
            int End = arr.Length - 1;

            while (Start <= End)
            {
                int mid = (int)(Start + End) / 2;
                if (SearchItem == arr[mid])
                {
                    return mid;
                }
                else if (SearchItem == arr[mid])
                {
                    End = mid - 1;
                }
                else
                {
                    Start = mid + 1;
                }
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide input for search item");
            string SearchItem = Convert.ToString(Console.ReadLine());
            string[] arr = { "Apple", "Kiwi", "Mango", "Peach" };
            int result = BinarySearch_Word(arr, SearchItem);
            if (result < 0)
            {
                Console.WriteLine($"{SearchItem} is not found");
            }
            else
            {
                Console.WriteLine($"{SearchItem} is found at index:{result}");
            }
        }
    }
}