// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");

string input=Console.ReadLine();
if(!input.Equals("exit"))
Console.WriteLine("вторая цифра {1}",input, input[1]);
