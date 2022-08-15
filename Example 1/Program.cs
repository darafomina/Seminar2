//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine ("Программа по нахождению второй цифры трёхзначного числа");

Console.WriteLine ("Введите трёхзначное число");
string? NumberString = Console.ReadLine ();
int number = int.Parse (NumberString!);

int x1 = number / 100;

int x2 = number % 10;

int x3 = (number - x1*100 - x2) / 10;

Console.WriteLine ("Вторая цифра: " + x3);


//Так же предложено альтернативное решение:
//(ввести сразу после строки "Console.WriteLine ("Введите трёхзначное число");")

//string str = Console.ReadLine();
//Console.WriteLine(str[1]);

//находит цифру в числе под индексом 1.