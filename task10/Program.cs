Console.WriteLine("Insert three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int b = (number % 100) / 10;
Console.Write($"{b}");