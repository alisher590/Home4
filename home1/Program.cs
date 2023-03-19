Console.Clear();
try{
Console.Write("Введите целое число A: ");
int NumA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число B: ");
int NumB = int.Parse(Console.ReadLine() ?? "");
int NumberOn = 1;
if (NumB < 1)
{
    Console.Write("Число B должно быть натуральным\n");
}
else
{
    while (NumB != 0)
    {
        NumberOn = NumberOn * NumA;
        NumB = NumB - 1;

    }
    Console.Write($"Число A в натуральной степени B равно {NumberOn}");
}
}
catch(Exception exc){
    Console.WriteLine($"Error Message!! -> {exc.Message}");
}



// int A = InputIntegerNumber("Введите целое число A: ", false);
// int B = InputIntegerNumber("Введите натуральное число B: ", true);
// int degree = PowerAB(A, B);
// PrintResult(A, B, degree);
// static int InputIntegerNumber(string msg, bool flagNatural)
// {
//   int num;
//   while (true)
//   {
//     try
//     {
//       Console.Write(msg);
//       num = int.Parse(Console.ReadLine() ?? "");
//       if (flagNatural)
//         if (num > 0) break;
//         else Console.WriteLine("Ошибка ввода натурального числа!");
//       else break;
//     }
//     catch (Exception exc)
//     {
//       Console.WriteLine($"Ошибка ввода! {exc.Message}");
//     }
//   }
//   return num;
// }
// static int PowerAB(int A, int B)
// {
//   int i = 0;
//   int result = 1;
//   while (i < B)
//   {
//     result *= A;
//     i++;
//   }
//   return result;
// }
// static void PrintResult(int a, int b, int deg)
// {
//   Console.WriteLine($"{a}, {b} -> {deg}");
// }








