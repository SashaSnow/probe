﻿int numberA = new Random() .Next(1, 10); // 1 2 3 4 ... 9 (случайное число)
Console.WriteLine(numberA);
int numberB = new Random() .Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);