// Домашнее задание № 4
Console.WriteLine("Введите три числа: ");
int numA = 2;
int numB = 13;
int numC = 23;
Console.WriteLine(numA);
Console.WriteLine(numB);
Console.WriteLine(numC);

int max = numA;
if (numB>max) max = numB;
if (numC>max) max = numC;
Console.Write("Максимальное число - ");
Console.WriteLine(max);
