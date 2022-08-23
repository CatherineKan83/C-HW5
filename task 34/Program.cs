void PrintArray(int[]arr)
{
    Console.Write("[");
    for(int i=0; i<arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]}");
        if(i<arr.GetLength(0)-1)
        {
            Console.Write(",");
        }
    }
Console.WriteLine("]");
}
void FillArray(int[]arr)
{
    for(int i=0;i<arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(100,999);
    }
Console.WriteLine();
}
void CountEven(int[]arr)
{
    int count = 0;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        if(arr[i]%2==0)
        {
            count ++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {count} ");    
}
Console.Write("Введите размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[]array = new int[c];
FillArray(array);
PrintArray(array);
CountEven(array);


