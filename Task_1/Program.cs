// Проверить - кратно ли введенное число одновременно 7 и 23
Console.WriteLine("Enter your number");
int a = int.Parse(Console.ReadLine()??"0");
if(a%7==0&&a%23==0)
{
    Console.WriteLine("Your number is aliquot to 7 and 23 at the same time");
}
else
{
    Console.WriteLine("Your number is not aliquot to 7 and 23 at the same time");
}
