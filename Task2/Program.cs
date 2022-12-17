// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arrLength = inputNumber("Введите размер массива: ");
int leftRange = inputNumber("Задайте начало массива: ");
int rightRange = inputNumber("Задайте конец массива: ");
int[] arr = FillArrayWithRandomNumbers(arrLength, leftRange, rightRange);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

int sum = 0;
for (int i = 1; i < arr.Length; i+=2)
    sum += arr[i];
Console.WriteLine($"Всего чисел {arr.Length}. Сумма элементов, стоящих на нечётных позициях = {sum}");

int[] FillArrayWithRandomNumbers(int arrLength, int leftRange, int rightRange)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

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