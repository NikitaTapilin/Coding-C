string a = Console.ReadLine();
int number = Convert.ToInt32(a);
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}
System.Console.WriteLine(sum);