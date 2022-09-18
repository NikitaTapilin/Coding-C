//Напишите программу, которая принимает на вход
// число n  и выдаёт таблицу квадратов от 1 до n.
int number = new Random().Next(1,99);
int[] array = new int[1];
for (int i = 1; i < number; i++)
{
    int[] newArray = array;
    array = new int[array.Length +1];
    for (int j = 0; j < newArray.Length; j++)
    {
        array[j] = newArray[j];
    }
    if (i * i % 5 ==0)
    {
        array[array.Length - 1] = i * i;
    }
    //Console.WriteLine(i * i);
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}