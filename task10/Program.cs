//int number=Console.WriteLine (100, 1000);
/*Console.WriteLine ("ввести трехзначное число");
int a =Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Вторая цифра трехзначного числа ='{a}'");



/*Console.WriteLine(number);

if(number > 99)
{
    Console.WriteLine((number / 100) % 10);
}
*/
Console.WriteLine("Введите трехзначное число");

string input=Console.ReadLine();
if(!input.Equals("exit"))
Console.WriteLine("вторая цифра {1}",input, input[1]);
