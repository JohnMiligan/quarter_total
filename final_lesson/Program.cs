string[] array = { "hello", "2", "world", ":-)", "333", "4444" };
int maxSizeString = 3;
int finalArrSize = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maxSizeString) finalArrSize++;
    else continue;
}

string[] FilterArray(string[] arr, int finalArrSize, int maxSize)
{
    string[] filteredArray = new string[finalArrSize];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= maxSize)
        {
            filteredArray[count] = arr[i];
            count++;
        }
        else continue;
    }
    return filteredArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] totalArray = FilterArray(array, finalArrSize, maxSizeString);
PrintArray(array);
Console.Write(" -> ");
PrintArray(totalArray);