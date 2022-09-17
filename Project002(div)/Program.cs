// Divide
// Console.Write("Введите делимое: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите делитель: ");
// double num2 = Convert.ToInt32(Console.ReadLine());
int num1 = new Random().Next(1, 10);
int num2 = new Random().Next(1, 10);
double res = num1 / num2;
Console.Write("Результат деления: ");
Console.WriteLine(res);
Console.ReadKey();
