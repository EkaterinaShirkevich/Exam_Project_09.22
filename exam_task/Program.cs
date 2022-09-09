// Написать программу, которая из имеющихся массивов строк формирует массив из строк, длина которых меньше или равнв 3 символа
//первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
//при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


string[] StringArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter an element:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void NewStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        int length = element.Length;
        if (length <= 3)
            Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine("Enter the number of array elements:");
int size = int.Parse(Console.ReadLine());
string[] arr_1 = StringArray(size);
Console.WriteLine("Your array is: ");
Print(arr_1);
Console.WriteLine("Result of this programm is: ");
NewStringArray(arr_1);

