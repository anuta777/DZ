# Задача № 23

// Напиши программу ,которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N/
Console.Write("Введите число (N)");

void CubeNumber(int number)

{

if (number < 0)
{
    Console.Write("Ввели отрицательное число");

    number = number * -1;
}

int count =1;

while (count <=number)
{
    int result = count*count*count;
    Console.Write(result + "");
    count ++;
}

}
int number = Convert.ToInt32(Console.ReadLine());

  CubeNumber(number);

Console.WriteLine();

