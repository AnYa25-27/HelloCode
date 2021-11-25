string[] weekDays = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt16(Console.ReadLine());

if ( number < 8)
if ( number > 0)
{
    Console.WriteLine($"Сегодня {weekDays[number-1]}");
}
else
{
    Console.WriteLine("Вы ввели неверный день недели");
}
