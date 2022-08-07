// See https://aka.ms/new-console-template for more information
Console.WriteLine("контрольная");
Console.Write("напишите несколько слов или чисел через пробел: ");
string first = Console.ReadLine();
string[] array = first.Split(' ');

PrintArray(array);
Console.WriteLine();
Console.Write("ответ: ");
for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= 3)
    {
        Console.Write(array[j] + " ");
    }
}




void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}