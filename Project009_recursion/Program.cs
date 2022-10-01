// Recursion

// Факториал n! = n * (n-1)!

// int Fuc(int n)
// {
//     if (n == 1) return 1;
//     else return n * Fuc(n - 1);
// }

// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine($"Factorial({i}) = {Fuc(i)}");
// }

// Числа Фибоначи f(n) = f(n-1) + f(n-2)

double Fibo(int n)
{
    if(n == 1 || n == 2) return 1;
    return Fibo(n-1) + Fibo(n-2);
}

for (int i = 1; i < 25; i++)
{
    Console.WriteLine($"f({i}) = {Fibo(i)}");
}

