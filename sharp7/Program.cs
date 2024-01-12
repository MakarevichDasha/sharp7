using System.Text.RegularExpressions;

// Открывается файл "input.txt" для чтения
StreamReader input = new StreamReader("input.txt");

// Создается объект StreamWriter для записи в файл "output.txt"
StreamWriter output = new StreamWriter("output.txt");

// Читается весь текст из файла и сохраняется в строке s
string s = input.ReadToEnd();

// Получается последняя цифра строки и преобразуется в целое число
int k = Convert.ToInt32(s.Substring(s.Length - 1, 1));

// Удаляется последний символ из строки s
s = s.Substring(0, s.Length - 1);

// Находятся все слова длиной не менее k символов в строке s
MatchCollection m = new Regex(@"\b\w{" + k + @",}\b").Matches(s);

// Если найдены слова, выводится их количество; иначе выводится -1 (при помощи иф элс)
if (m.Count > 0)
    output.WriteLine(m.Count);
else
    output.WriteLine(-1);

// Закрываются потоки чтения и записи
input.Close();
output.Close();