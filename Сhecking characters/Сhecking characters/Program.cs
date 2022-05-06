
class Programm
{
    public static bool Check(string text)
    {
        int count = 0;
        char[] storage = new char[100];
        foreach (char element in text)
        {
            switch (element)
            {
                case '{': storage[++count] = element; break;
                case '[': storage[++count] = element; break;
                case '(': storage[++count] = element; break;
                case '}': if (storage[count] == '{') { count--; } else { return false; }; break;
                case ']': if (storage[count] == '[') { count--; } else { return false; }; break;
                case ')': if (storage[count] == '(') { count--; } else { return false; }; break;
            }
        }
        return count == 0 ? true : false;
    }

    static void Main(string [] args)
    {
        Console.WriteLine(Check(Console.ReadLine()));
        Console.ReadKey(true);
    }
}