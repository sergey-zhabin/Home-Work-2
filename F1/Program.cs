//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
Zada4a_13(number);
void Zada4a_13(string arg)
{
    if (arg.Length < 3 )
    Console.WriteLine(" третьей цифры нет ");
    else
    Console.WriteLine(arg[2]);
}