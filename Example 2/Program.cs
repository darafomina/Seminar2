//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Программа по нахождению третей цифры числа");

Console.WriteLine ("Введите число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if (number > 99)
    Console.WriteLine("Третья цифра: " + number.ToString()[2]);
else if  (number < -99)
    Console.WriteLine("Третья цифра: " + number.ToString()[3]);
else
    Console.WriteLine("Третьей цифры нет");