//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Введите число ");
int DofW = Convert.ToInt32(Console.ReadLine());
Week(DofW);
void Week(int DofW)
{
   
    if ( DofW == 6 || DofW == 7 )
    {
    Console.WriteLine(" выходной день, а какой именно, не важно ");
    }
    else if(DofW == 1)
    {
   Console.WriteLine( "Понедельник - Будень ");
    }
    else if(DofW == 2)
    {
   Console.WriteLine( "Вторник - Будень ");
    }
    else if(DofW == 3)
    {
   Console.WriteLine( "Среда - Будень ");
    }
    else if(DofW == 4)
    {
   Console.WriteLine( "Четверг - Будень ");
    }
    else if(DofW == 5)
    {
   Console.WriteLine( "Пятница - Будень ");
    }
}