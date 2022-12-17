// // Вид 1 Ничего не принимают, ничего не возвращают
// void Method1()
// {
//     Console.WriteLine("Автор: Кира");
// }
// // Вызов метода делается со скобками!
// Method1();

// // Вид 2 Ничего не возвращают, но могут принимать какие-то методы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Вызов метода делается со скобками!
// Method2("Текст сбщ");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
    
// }
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");

// // Вид 3 Что-то возвращают, но ничего не принимают
// int Method3()
// {
// // Обязательно использование оператора return 
//     return DateTime.Now.Year;
// }

// int  year=Method3();
// Console.WriteLine(year);

// // Вид 4 Что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i=0;
// // переменная, в которую будем складывать конечный результат string result
//     string result=String.Empty;

//     while(i<count)
//     {
//         result=result+text;
//         i++;
//     }
// // Указываем переменную, которую рассчитываем получить из метода
//     return result;
// }

// string res=Method4(10,"text");
// Console.WriteLine(res);

// // Цикл for
// string Method4(int count, string text)
// {
//     string result=String.Empty;
//     for (int i=0;i<count; i++)
//     {
//         result=result+text;
//     }
//     return result;
// }

// string res=Method4(10,"text");
// Console.WriteLine(res);

// // Цикл в цикле
// // Вывод таблицы умножения на экран. i - первый множитель в таблице, j - второй множитель

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
              + "ежели бы вас послали вместо нашего милого Винценгероде,"
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result=String.Empty;
    int length=text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result=result + $"{newValue}";
        else result=result + $"{text[i]}";
    }


    return result;
}
string newText=Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText, 'С', 'с');
Console.WriteLine(newText);