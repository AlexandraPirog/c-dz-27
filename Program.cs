// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum= Variant(num);

int Variant(int num)
{
int result =0;
for (int i = 0; num>0 ; i++)
{
    result = result + num % 10;
    num = num/ 10; 
}
return result; 
}
System.Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
