Console.WriteLine("Insert number");
int number = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(number);
if (array.Length > 2)
{
  Console.WriteLine("third digit = " + array[2]);
}
else 
{
  Console.WriteLine("no third digit");
}
