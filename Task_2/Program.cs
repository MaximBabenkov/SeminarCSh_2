// Определить номер четверти, в которой находится точка с координатами x и y, 
//  x и y не равны 0
Console.WriteLine("Enter your x coordinate");
int x = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter your y coordinate");
int y = int.Parse(Console.ReadLine()??"0");
if(x>0&&y>0) Console.WriteLine("The point locates in quarter 1");
else if(x<0&&y>0) Console.WriteLine("The point locates in quarter 2");
else if(x<0&&y<0) Console.WriteLine("The point locates in quarter 3");
else if(x>0&&y<0) Console.WriteLine("The point locates in quarter 4");
