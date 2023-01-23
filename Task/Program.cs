// необходимо создать программу которая из имеющегося массива строк
// формирует массив из элементов колличество символов которого меньше или равнот N

Console.Clear();
Console.Write("Введите длинну масива - ");
int a = int.Parse(Console.ReadLine());
string[] arr = new string[a];
Console.WriteLine();

FillArrey(arr);
Console.Write("\nКакое максимальное колличество символов должно быть в элементе массива - ");
int N = int.Parse(Console.ReadLine());
Console.Write("\nЭлементы  массива удовлетворяющие заданному условию - ");
PrintArray(arr, N);





void FillArrey(string[] array) // Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент масива - ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array, int n) // Вывод массива на экран с условием задачи
{
    Console.Write(" [");

    for (var i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length <= n)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    if (array[array.Length - 1].Length <= n)
    {
        Console.Write(array[array.Length - 1]);
    }
    Console.WriteLine("]");
}