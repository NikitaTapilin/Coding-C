﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//             0   1   2   3   4   5   6    7   8
int[] array = {21, 122, 36, 44, 25, 76, 37, 18, 93 };
// array[0] = 12; // присовение значения элементу списка
// Console.WriteLine(array[4]); // вывод определенного элемента

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(result);
