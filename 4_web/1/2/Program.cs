 //выводит массив из 8 элементов, заполненного 0 и 1 в случайном порядке
 //должно быть 2 метода (1 создаёт и заполняет, 2 выводит)
 
 void new_array(int [] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
        i ++;
    }
 }

 void print_array(int [] array)

{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

int [] array = new int [8];
new_array(array);
print_array(array);
