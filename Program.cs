using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7, 8, 9, 10 };

        int[] mergedArray = new int[array1.Length + array2.Length];
        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
    }
}

/*
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int positions = 2; 

        RotateArray(array, positions);

        Console.WriteLine("Ротированный массив: " + string.Join(", ", array));
    }

    static void RotateArray(int[] array, int positions)
    {
        int length = array.Length;
 
        positions = positions % length;

        int[] rotatedArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            rotatedArray[(i + positions) % length] = array[i];
        }
        Array.Copy(rotatedArray, array, length);
    }
}
*/