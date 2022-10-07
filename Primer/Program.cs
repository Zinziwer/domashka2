//Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Random random = new Random();
void Zadacha10()
{
    int number = random.Next(100, 1000);
    Console.WriteLine(number);
    Console.WriteLine(number/10%10);
}
Zadacha10();
Console.WriteLine("-------------------");

//Напишите программу, которая с помощью деления выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
void Zadacha13()
{
    // int number = random.Next(1, 100);
    // Console.WriteLine(number);
     Console.WriteLine("Enter a more than two-digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number)/100<1)
    {
        Console.WriteLine("The third digit is missing");
    }
    else 
    {
        int numberx = Math.Abs(number);
        while (numberx>1000)
        {
            numberx=numberx/10;
        }
        Console.WriteLine(numberx%10);
    }
    
}
Zadacha13();
Console.WriteLine("-------------------");


//Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
void Zadacha15()
{
    string[]  Week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    Console.WriteLine("Enter the number of a day of a week (1-7) ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day==6 || day == 7)
    {
        Console.WriteLine(Week[day-1] + " - is weekend day");
    }
    else
    {
        Console.WriteLine(Week[day-1] + " - is not a weekend day");
    }
}
Zadacha15();