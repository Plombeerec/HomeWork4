// Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

int SumIntegersInNum(int number)
{
    int result = 0, sum = 0;
    
    while (number > 0)
    {
        result = number % 10;
        number = number / 10;
        sum += result;
    }
    return sum;
}

Console.Write("Input positiv intger number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum is" +  SumIntegersInNum(num));