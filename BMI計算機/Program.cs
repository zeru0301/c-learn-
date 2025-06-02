
while (true)
{

    Console.WriteLine("あなたの名前を入力してください");
    string? userName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userName))
    {

        Console.WriteLine("注意:名前の入力がありません。もう一度お願いします");
        continue;
    }

    Console.WriteLine("あなたの体重を入力してください");
    string? userWT = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userWT) || !int.TryParse(userWT,out int WT))
    {

        Console.WriteLine("注意:体重の入力がありません。もう一度お願いします");
        continue;
    }
   

    Console.WriteLine("あなたの身長を入力してください");
    string? userHT = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userHT) || !int.TryParse(userHT,out int HT))
    {

        Console.WriteLine("注意:身長の入力がありません。もう一度お願いします");
        continue;
    }
    double HTu = HT * 0.01;
    Console.WriteLine(HTu);
    Console.WriteLine(WT);

    double  userBMI = WT / (HTu * HTu) ;
    Console.WriteLine($"{userName} さんのBMI数値は{ userBMI:F2} です");
    break;
}