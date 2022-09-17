// Find max
int[] arr = {3, 5, 8, 4, 2, 7};
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    max = arr[i]>max ? arr[i] : max;
}
Console.Write("Максимальное значение массива: ");
Console.Write(max);

