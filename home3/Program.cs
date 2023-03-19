Console.Clear();
int len = InputIntegerNumber("Введите длину массива: ", true);
int beginValue = InputIntegerNumber("Введите начальное значение диапозона сучайных чисел: ", false);
int endValue = InputIntegerNumber("Введите конечное значение диапозона сучайных чисел: ", false);
int[] arr = CreateArray(len, beginValue, endValue);
PrintArray(arr);
static int InputIntegerNumber(string msg, bool flagNatural)
{
    int num;
    while (true)
    {
        try
        {
            Console.Write(msg);
            num = int.Parse(Console.ReadLine() ?? "");
            if (flagNatural)
                if (num > 0) break;
                else Console.WriteLine("Ошибка ввода натурального числа!");
            else break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }
    return num;
}
static int[] CreateArray(int len, int a, int b)
{
    if (a > b)
    { 
        int temp = a; 
        a = b; 
        b = temp; 
    }
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(a, b + 1);
    }
    return array;
}
static void PrintArray(int[] array)
{
    Console.Write("[");
    int i;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[i]);
    Console.WriteLine("]");
}
