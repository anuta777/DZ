# DZ
Задача№2
// Напишите программу,которая на вход принимает два числа и выдает,которое меньше.

// a =5; b = 7 -> max=7

//a=2; b=10->max=10


// a=-9;b=-3->max=-3

Console.WriteLine("Введите первое число");

int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе числ");

int numberb = Convert.ToInt32(Console.ReadLine());

if (numbera > numberb)

{

    Console.WriteLine("Большее число:>>+numbera +<<,меньшее число:>>+numberb");

}

else Console.WriteLine($">>Большее число:{numbera},>меньшее число:{numberb}>>");
