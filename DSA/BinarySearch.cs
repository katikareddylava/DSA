
namespace DSA
{
    public class BinarySearch
    {
        public void CallBS()
        {
            Console.WriteLine("**************************Assume array should be in sorted order**************************");
            Console.WriteLine("Please enter the size of the array: ");
            string? input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input) && input.ToLower() != "quit" && input.ToLower() != "exit")
            {
                int size = Convert.ToInt32(input);
                int[] arr = new int[size];
                Console.WriteLine("Please enter the values in array: ");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Please enter the target: ");
                int target = Convert.ToInt32(Console.ReadLine());

                int index = BinarySearchMethod(arr, target);
                Console.WriteLine("Target found at index: " + index);

                Console.WriteLine("Please enter the size of the array to continue or please type EXIT or QUIT to close the program ");
                input = Console.ReadLine();
            }
        }

        public static int BinarySearchMethod(int[] arr, int target)
        {
            int s = 0;
            int e = arr.Length - 1;
            // find array is in ascending or descending;
            bool isAsc = arr[s] < arr[e];
            while (s <= e)
            {
                int m = s + (e - s / 2); // to bypass error of int max value for huge arr length;

                if (arr[m] == target)
                {
                    return m;
                }

                if (isAsc)
                {
                    //Ascending order
                    if (target < arr[m])
                    {
                        e = m - 1;
                    }
                    else
                    {
                        s = m + 1;
                    }
                }
                else
                {
                    //Descending order
                    if (target > arr[m])
                    {
                        e = m - 1;
                    }
                    else
                    {
                        s = m + 1;
                    }
                }
            }
            return -1;
        }
    }
}
