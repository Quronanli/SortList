using System;

class Program

{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 3, 5, 1, 8, 4, 2, 9, 7, 6, 10, 12, 11, 15, 13, 14, 19, 17, 16, 20, 18, 23, 21, 22, 26, 25, 27, 28, 24, 30, 29 };
        int minIndex, temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
        Console.WriteLine("Відсортований масив:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}