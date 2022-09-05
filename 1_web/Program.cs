//тип данных, название и данные
// int a = 12; //int - целочисленные данные
// float b = 23.4f; //float - дробные числа
// double c = 8.4; // double - дробные числа
// string d = "Hello World"; //string - строковые данные (двойные кавычки)
// bool e = true; //false //bool данные с условием (истина или ложь)
// Console.WriteLine(a * b + 20 /c - 50);

//Про конвертацию и объедениние типов данных
// Console.WriteLine("Введите имя: ");
// string name = Console.ReadLine();
// int number = Convert.ToInt32(name); //переводим строку в число
// System.Console.WriteLine("Hello, " + (Convert.ToInt32(name) + 2));

Console.Write("Введите число от 1 до 10: ");
string numberString = Console.ReadLine();
int number = Convert.ToInt32(numberString);
int secretNum = 7;
if (number > secretNum)
{
    Console.WriteLine("Секретное число меньше!");
}
else if(number < secretNum)
{
    System.Console.WriteLine("Секретное число больше!");
}
else
{
    System.Console.WriteLine("Вы угадали!");
}