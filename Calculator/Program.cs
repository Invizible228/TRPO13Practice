// See https://aka.ms/new-console-template for more information
Console.Write("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Выберите цифру:\n1 - '+'\n2 - '-'\n3 - '*'\n4 - '/'\nВаш вариант: ");
int lever = Convert.ToInt32(Console.ReadLine());
switch (lever)
{
    case 3: Console.WriteLine(a * b); break;
}
