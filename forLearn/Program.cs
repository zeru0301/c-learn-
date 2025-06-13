// for文の学習
// １０までのカウントここではwhile文よりもfor 条件; i++の構文の黄河適していると思ったため使用

for (int i = 0; i <= 10; i++){
    Console.WriteLine(i);
}

// 奇数表示プログラム
//条件　20までとする

for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

//  3の倍数の合計を出す
// 30までの数から、3の倍数だけを取り出し足す
List<int> arrey = new List<int>();
for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        arrey.Add(i);
    }
}
// 今回使用していない後で気づいた謎に取得した長さ
// int listLegth = arrey.Count;

int A = 0;
foreach (int B in arrey)
{
    A = A + B;

}
Console.WriteLine($"答えは{A}です。");