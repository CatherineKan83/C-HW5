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
        arr[i] = new Random().Next(-10,90);
    }
Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[]array = new int[c];
FillArray(array);
PrintArray(array);
int dif = array.Max() - array.Min();
Console.WriteLine($"Максимальным элементом является [{array.Max()}], минимальным [{array.Min()}]. Разница между ними составляет {dif}. ");  




