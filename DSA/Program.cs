// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter the target: ");
int target = Convert.ToInt32(Console.ReadLine());

int index = binarySearch(new int[] { 2, 4, 6, 8, 10, 12, 14, 20, 24, 25 }, target);

Console.WriteLine(index);
Console.ReadKey();


static int binarySearch(int[] arr, int target)
{
    int s = 0;
    int e = arr.Length - 1;
    while (s <= e)
    {
        int m = (s + e) / 2;
        if (target < arr[m])
        {
            e = m - 1;
        }
        else if (target > arr[m])
        {
            s = m + 1;
        }
        else
        {
            return m;
        }
    }
    return -1;
}
