int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

foreach (var i in BubbleSort(intArray))
{
    Console.WriteLine(i);
}


Console.ReadLine();

int[] BubbleSort(int[] array)
{
    // Hold temporary swap variable. Think state
    int temp = 0;

    // Iterates over entire loop many times
    for (int pointer = 0; pointer < array.Length; pointer++)
    {
        // Forms the "box" that does the comparison
        for (int sort = 0; sort < array.Length - 1; sort++) {

            if (array[sort] > array[sort + 1]) {
                //Swap
                //We Store variable as temp so we dont overwrite it when we swap
                temp = array[sort + 1];

                //put left variable in the right
                array[sort + 1] = array[sort];

                //put the right variable in the left
                array[sort] = temp;
            }
        }  
    }

    return array;
}