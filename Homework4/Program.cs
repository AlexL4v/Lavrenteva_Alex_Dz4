 // Задача 1 
 //  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

 void multiplication(int valA, int valB)
{
    int result = valA;
    for(int n = 1; n < valB; n++)
    {
        result = result * valA;
    }
    
    Console.WriteLine((valA) + " в степени " + (valB) + " ранво " + (result));

    
}
Console.WriteLine("Введите первое натуральное число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число ");
int B = Convert.ToInt32(Console.ReadLine());
if (A < 1 || B < 1) Console.WriteLine("Упс! Введенные числа не являются натуральными. Попробуйте еще раз)");
else multiplication(A, B);


// Задача 2 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int numA)
{
    int N = 0;
    while (numA != 0)
    {
        N = N+numA%10;
        numA = numA/10;
    
    }
         
    return N;
}

Console.WriteLine("Введите целое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр данного числа составляет {Sum(A)}");
*/

// Задача 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Array()
{
    int[] n = new int[8];
    for (int i = 0; i<8; i++ )
    {
        n[i] = new Random().Next(0, 999);
        Console.Write(n[i] + " ");
    }
}
Array();