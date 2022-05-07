
class Programm
{
    //public static bool Check()
    //{
    //    Console.WriteLine("Введите колличество символов в строке");
    //    int numberOfCharacters = int.Parse(Console.ReadLine());
    //    char[] storage = new char[numberOfCharacters];
    //    int count = 0;
    //    string text = Console.ReadLine();
    //    int countChar = text.Length;
    //    if (numberOfCharacters < countChar)
    //    {
    //        Console.WriteLine("Неверное колличество символов");
    //    }
    //    foreach (var element in text)
    //    {
    //        switch (element)
    //        {
    //            case '{': storage[++count] = element; break;
    //            case '[': storage[++count] = element; break;
    //            case '(': storage[++count] = element; break;
    //            case '}': if (storage[count] == '{') { count--; } else { return false; }; break;
    //            case ']': if (storage[count] == '[') { count--; } else { return false; }; break;
    //            case ')': if (storage[count] == '(') { count--; } else { return false; }; break;
    //        }
    //    }
    //    if (count == 0)
    //        Console.WriteLine("Вывод корректный");
    //    else
    //        Console.WriteLine("Вывод неккоректный");
    //    return count == 0;
    //}
    static void Main(string[] args)
    {
        //Check();
        //Console.ReadKey(true);
        //string input = Console.ReadLine();

        //int result = Check(input);

        //Console.WriteLine(result == -1 ? "Success" : result.ToString());
        //Console.Read();
        Console.WriteLine(IsPaired(Console.ReadLine()));
    }

    //static int Check(string text)
    //{
    //    Stack<char> stack = new Stack<char>();
    //    Stack<int> stackIndexes = new Stack<int>();
    //    for (int i = 0; i < text.Length; i++)
    //    {
    //        char ch = text[i];

    //        if (ch == '(' || ch == '{' || ch == '[')
    //        {
    //            stack.Push(ch);
    //            stackIndexes.Push(i);
    //        }
    //        else if (ch == ')' || ch == ']' || ch == '}')
    //        {
    //            if (stack.Count == 0)
    //                return i + 1;
    //            char top = stack.Pop();
    //            int temp = stackIndexes.Pop();
    //            if ((top == '[' && ch != ']')|| (top == '(' && ch != ')')||(top == '{' && ch != '}'))
    //                return i + 1;
    //        }
    //    }
    //    return stack.Count == 0?-1:stackIndexes.Pop();
    //}
    public static bool IsPaired(string input)
    {
        string opening = "{[(";
        string closing = "}])";

        List<char> opening_brackets = new List<char> { };
        List<char> closing_brackets = new List<char> { };

        if (input.Count() == 0) { return true; }

        foreach (char i in input)
        {
            if ((opening + closing).Contains(i))
                if (opening.Contains(i) is true) { opening_brackets.Add(i); }
                else
                {
                    closing_brackets.Add(i);

                    if (opening_brackets.Count == 0) { return false; }

                    char required_prev_opening = opening.ElementAt(closing.LastIndexOf(i));

                    if (required_prev_opening != (char)opening_brackets.Last()) { return false; }

                    opening_brackets.RemoveAt(opening_brackets.Count - 1);
                    closing_brackets.RemoveAt(closing_brackets.Count - 1);
                }
        }

        if (opening_brackets.Count != 0 || closing_brackets.Count != 0)
        {
            return false;
        }
        return true;
    }
}