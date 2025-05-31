// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Hello, World!");

//条件分岐
Console.WriteLine("なたの名前を入力してください>>");
string? userName = Console.ReadLine();

Console.WriteLine("なたの年齢を入力してください>>");
string? userAge = Console.ReadLine();

if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userAge))
{
    Console.WriteLine("入力が行われておりません！");
    return;
    //この分岐が選ばれた場合ここで処理を終了させる。
}

int Age = int.Parse(userAge);

if (Age < 20)
{
    Console.WriteLine(userName + "は未成年です");
}
else
{
    Console.WriteLine(userName + "は成人です");
}

