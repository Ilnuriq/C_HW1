/*
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");
*/

/*
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
 if (firstNumber > thirdNumber)
    {
 Console.WriteLine("Максимальное число: " + firstNumber);
    }
 else
    {
 Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
*/

/*
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
        if ((x % 2) == 0)
        {
            Console.WriteLine("Четное");
        }
        else
        {
            Console.WriteLine("Нечетное");
        }
*/

Console.Write("Введите число: ");
 int n = int.Parse(Console.ReadLine());
 for (int i = 1; i <= n; i++)
 {
     if (i % 2 == 0) 
     {
        Console.Write(i + " ");
     }
}