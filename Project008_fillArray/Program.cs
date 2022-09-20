// Fill my Array
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

int[] myArr = new int[10];
FillArray(myArr);

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]},");
        }
    }
    Console.Write("]");
}

PrintArray(myArr);

int idxOf(int[] arr, int el)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == el) return i;
    }
    return -1;
}

Console.Write(idxOf(myArr, 5));
