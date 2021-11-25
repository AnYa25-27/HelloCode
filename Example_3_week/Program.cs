//

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt16(Console.ReadLine()); //Convert.ToInt16(Console.ReadLine());
switch (day)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник");break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье");break;
 default: Console.WriteLine("Ошибка, вы ввели неверное число!");break;
}
Console.Write(day);
