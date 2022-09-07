Console.WriteLine("Введите длину массива: ");
int num_user = int.Parse(Console.ReadLine());
int [] array = new int[num_user];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-999, 999);
}

Console.WriteLine(string.Join(" ", array));

int max = 0;
for (int j = 0; j < array.Length; j++)
{
    if (max < array[j]) max = array[j];
}
Console.WriteLine(max);

int min = array[0];
for (int k = 0; k < array.Length; k++)
{
    if (min > array[k]) min = array[k];
}
Console.WriteLine(min);