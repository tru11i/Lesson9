// Task1

// class Program
// {
//     static void Main()
//     {
//         int N1 = 5;
//         Console.WriteLine(PrintNaturalNumbers(N1));

//         int N2 = 8;
//         Console.WriteLine(PrintNaturalNumbers(N2));
//     }
//     static string PrintNaturalNumbers(int N)
//     {
//         if (N == 1)
//         {
//             return "1";
//         }

//         return $"{N}, {PrintNaturalNumbers(N - 1)}";
//     }
// }

// Task2

// class Program
// {
//     static void Main()
//     {
//         int M1 = 1;
//         int N1 = 15;
//         Console.WriteLine($"Сумма натуральных чисел от {M1} до {N1}: {CalculateSum(M1, N1)}");

//         int M2 = 4;
//         int N2 = 8;
//         Console.WriteLine($"Сумма натуральных чисел от {M2} до {N2}: {CalculateSum(M2, N2)}");
//     }

//     static int CalculateSum(int M, int N)
//     {
//         int sum = 0;

//         for (int i = M; i <= N; i++)
//         {
//             sum += i;
//         }

//         return sum;
//     }
// }

// Task3


// class Program
// {
//     static void Main()
//     {
//         int m1 = 2, n1 = 3;
//         Console.WriteLine($"A({m1}, {n1}) = {AckermannFunction(m1, n1)}");

//         int m2 = 3, n2 = 2;
//         Console.WriteLine($"A({m2}, {n2}) = {AckermannFunction(m2, n2)}");
//     }

//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else if (m > 0 && n > 0)
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//         else
//         {
//             throw new ArgumentException("Некорректные входные данные");
//         }
//     }
// }