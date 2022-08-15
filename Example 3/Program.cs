//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Программа по нахождению выходного дня");

Console.WriteLine ("Введите число");
string? NumberString = Console.ReadLine ();
int number = int.Parse (NumberString!);

if(number >= 1 && number <= 5)
{
    Console.WriteLine("Будний день");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
}
else
Console.WriteLine("Введите цифру, соответствующую дню недели");