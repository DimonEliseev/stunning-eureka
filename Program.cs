// /Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 

Console.WriteLine("Сколько элементов ввести");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] arrayStrings = new string[size];
int pos = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"введите {i+1}й элемент: ");
    string element = Console.ReadLine() ?? "0";
    if (element.Length <=3)
    {
        arrayStrings[pos] = element;
        pos++;
    }
}
Console.WriteLine();
void PrintArray(string[] arr)
{
    Console.Write("[ " + arr[0] + " ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]);
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    
}
PrintArray(arrayStrings);
Console.WriteLine();

