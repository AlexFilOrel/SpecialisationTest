/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

string[] CreateFirstArray(int size)
{
    string[]firstArray = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i+1} element ");
        firstArray[i] = Convert.ToString(Console.ReadLine())!;
    }
    return firstArray;
}
void PrintArray(string[]array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] CreateFinalArray(string[] array, int size)
{
    string[]finalArray = new string [size];
    int elemetLength = 3;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elemetLength)
        {
            finalArray[index] = array[i];
            index++;
        }
    }
    return finalArray;
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = CreateFirstArray(size);
PrintArray(firstArray);
Console.WriteLine();
string[] finalArray = CreateFinalArray(firstArray, size);
PrintArray(finalArray);
Console.WriteLine();