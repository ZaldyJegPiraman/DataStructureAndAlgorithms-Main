using System;


static int BinarySearch(int[] array, int target)
{
    int low = 0;
    int high = array.Length - 1;

    while (low <= high)
    {
        int middle = (low + high) / 2;
        if (array[middle] == target)
        {
            return middle; // Target found
        }
        else if (array[middle] < target)
        {
            low = middle + 1; // Search in the right half
        }
        else
        {
            high = middle - 1; // Search in the left half
        }
    }

    return -1; // Target not found
}

 
int[] array = { 1, 5, 8, 12, 14, 23, 27, 31, 45, 52 };
int target = 23;
int result = BinarySearch(array, target);

if (result != -1)
{
    Console.WriteLine($"Target {target} found at index {result}.");
}
else
{
    Console.WriteLine($"Target {target} not found in the array.");
}
    

