Console.Write("Введите ваше имя: ");
string? I = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string? F = Console.ReadLine();
Console.Write("Введите ваше отчество: ");
string? O = Console.ReadLine();
Console.WriteLine($"{F} {I} {O}, привет!");


Console.Write($"{I}, введите первое значение: ");
string f_value = Console.ReadLine();
double first_value = Convert.ToDouble(f_value);

Console.Write($"{I}, введите второе значение: ");
string f_value2 = Console.ReadLine();
double second_value = Convert.ToDouble(f_value2);

Console.Write($"{I}, введите действие: ");
string operation = Console.ReadLine();

double result = 0;

if (operation == "+")
{
    result = first_value + second_value;
}
if (operation == "-")
{
    result = first_value - second_value;
}
if (operation == "*")
{
    result = first_value * second_value;
}
if (operation == "/")
{
    result = first_value / second_value;
}
Console.WriteLine(result);