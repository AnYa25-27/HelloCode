double numberA = new Random().Next();
double numberB = new Random().Next();
double numberC = new Random().Next();

double max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное значение {max} ");