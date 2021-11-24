// По двум заданным числам проверять является ли первое квадратом второго

double numberA = 9;
double numberB = 3;
if (Math.Sqrt(numberA) == numberB)  //Math.Sqrt(Double)	- Возвращает квадратный корень из указанного числа.
{
    Console.WriteLine("Является");
}
else 
{
    Console.WriteLine("Не является");
}