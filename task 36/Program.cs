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
        arr[i] = new Random().Next(-10,100);
    }
Console.WriteLine();
}
void CountSum(int[]arr)
{
    int count = 0;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        if(i%2!=0)
        {
            count += arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {count} ");    
}
Console.Write("Введите размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[]array = new int[c];
FillArray(array);
PrintArray(array);
CountSum(array);



