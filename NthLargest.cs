using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter " +size+ "elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the value of N (for N-th largest element): ");
        int N = int.Parse(Console.ReadLine());
        if (N > size || N <= 0)
        {
            Console.WriteLine("Invalid value of N.");
            return;
        }
        SelectionSortDescending(arr);
        Console.WriteLine("The {N}-th largest element is" +arr[N - 1]);
    }

    static void SelectionSortDescending(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[maxIndex];
            arr[maxIndex] = temp;
        }
    }
}
