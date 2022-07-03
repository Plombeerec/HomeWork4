// Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

int[] array = {0,0,0,0,0,0,0,0};
int i = 0 ;


while ( i < array.Length)
{
    Console.Write($" etner {i} digit:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

var str = string.Join(" ", array);
Console.WriteLine(str);
