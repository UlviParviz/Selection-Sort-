int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
int n = 10;
int k, min;
for (int i = 0; i < n - 1; i++)
{
    min = i;
    for (int j = i + 1; j < n; j++)
    {
        if (arr[j] < arr[min])
        {
            min = j;
        }
    }
    k = arr[min];
    arr[min] = arr[i];
    arr[i] = k;
}
Console.Write("Sorted array is: ");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
