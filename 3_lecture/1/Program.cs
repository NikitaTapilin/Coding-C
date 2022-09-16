//1 не принимает, не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//2 принимают, но не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Hello");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1(count: 4, msg: "Text");

//3 не принимают, но возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4 принимают и возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "dot");
Console.WriteLine(res);