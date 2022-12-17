// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arrLength = inputNumber("Введите размер массива: ");
int[] arr = AutoArray(arrLength);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

int count = 0;
for (int num = 0; num < arr.Length; num++)
    if (arr[num] % 2 == 0)
        count++;
Console.WriteLine($"Всего чисел {arr.Length}, из них {count} чётные");

int inputNumber(string message)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

// Функция автозаполнения массива
int[] AutoArray(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    return arr;
}



