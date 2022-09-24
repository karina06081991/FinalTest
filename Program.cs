// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина
// которых меньше, либо равна 3 символам.

string [] M;
Console.WriteLine("введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);