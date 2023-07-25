static int GetInput(String tex)
{
    Console.Write(tex);
    return Convert.ToInt32(Console.ReadLine());
}

int count = 0;
while (true)
{
    int number = GetInput("Введите любое целое число: ");
    if (number > 0) count++;
    Console.Clear();
    Console.WriteLine($"Количество положительных чисел равно {count}.");
    Console.WriteLine("Для завершения работы нажмите любой символ и 'Enter'.");
}