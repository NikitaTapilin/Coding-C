int max_num(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15; int b1 = 21; int c1 = 39;
int a2 = 12; int b2 = 81; int c2 = 33;
int a3 = 56; int b3 = 23; int c3 = 33;

// int max1 = max_num(a1, b1, c1);
// int max2 = max_num(a2, b2, c2);
// int max3 = max_num(a3, b3, c3);
// int max = max_num(max1, max2, max3);
int max = max_num(max_num(a1, b1, c1), max_num(a2, b2, c2), max_num(a3, b3, c3));

Console.WriteLine(max);