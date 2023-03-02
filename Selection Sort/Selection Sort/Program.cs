int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
int n = 10;
int temp, min;
for (int i = 0; i < n-1; i++)
{
    min = i;
    for(int j=i+1;j<n;j++)
    {
        if (arr[j] < arr[min])
        {
            min = j;
        }
    }
    temp = arr[min];
    arr[min] = arr[i];
    arr[i] = temp;
}
for (int i = 0;i < n;i++)
{
    Console.WriteLine(arr[i]);
}
