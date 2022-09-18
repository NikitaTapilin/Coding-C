int[] array = new int [new Random().Next(1,100)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
}
Console.WriteLine(string.Join(" ", array));

int max = array[0];
for (int j = 1; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
}
System.Console.WriteLine($"Самое большое число: {max}");