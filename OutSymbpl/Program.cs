Console.WriteLine("Введите первую строку:");
string str1 = Console.ReadLine().ToLower(); 

Console.WriteLine("Введите вторую строку:");
string str2 = Console.ReadLine().ToLower(); 

Console.WriteLine("Символы, встречающиеся в обеих строках:");

foreach (char ch in str1)
{
    if (str2.Contains(ch))
    {
        int index1 = str1.IndexOf(ch) + 1;
        int index2 = str2.IndexOf(ch) + 1;
        Console.WriteLine($"{ch} встречается в строке 1 на позиции {index1} и в строке 2 на позиции {index2}");
    }
}

if (str1 == "" || str2 == "")
{
    Console.WriteLine("NO");
}