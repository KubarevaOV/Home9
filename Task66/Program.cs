/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Raw(int M, int N, int sum) {
    if (M > N) {
        Console.WriteLine("{0}", sum);
    } else {
        sum = sum + M;
        Raw(M+1, N, sum);
    }
}
Raw(4, 8, 0);