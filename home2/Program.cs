Console.Clear();
try{
int num = ReadNum("Введите число: ");
int comand = NumberCount(num);
SumNumbers(num, comand);
int ReadNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberCount(int a)
{
    int crash = 0;
    while (a > 0)
    {
        a /= 10;
        crash++;
    }
    return crash;
}
void SumNumbers(int n, int comand)
{
    int result = 0;
    for (int i = 1; i <= comand; i++)
    {
        result += n % 10;
        n /= 10;
    }
    Console.WriteLine($"{num} ->{result}");
}
}
catch(Exception exc){
    Console.Write($"Error Message!! -> {exc.Message}");
}
