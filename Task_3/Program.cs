// Проверить пятизначное число на палиндром
Console.WriteLine("Enter your five-digit number");
int a = int.Parse(Console.ReadLine()??"0");
if(a/10000==a%10&&(a/1000)%10==(a/10)%10)
{
    Console.WriteLine("Your number is a palindrome");
}
else
{
    Console.WriteLine("Your number is not a palindrome");
}
