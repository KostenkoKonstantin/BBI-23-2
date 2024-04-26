// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
class program
{
    public static void Main(string[] args)
    {
        string text1 = Console.ReadLine();
        string text2 = Console.ReadLine();

        var capWords = CapWords(text1);
        var TrueFalse = CheckBrackets(text2);

        Console.WriteLine(string.Join(" ", capWords));
        Console.WriteLine(TrueFalse);

    }
    static int CapWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            counter++;
        }
        return counter;
    }

    static bool CheckBrackets(string text)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in text)
        {
            if (ch == '{' || ch == '[' || ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == '}' || ch == ']' || ch == ')')
            {
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), ch))
                {
                    return false;
                }
            }
            return true;
        }

        return stack.Count == 0;
    }
    static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '{' && closing == '}') || (opening == '[' && closing == ']');
    }

    class JsonIO
    {
        public static void ProcessJson<T>(string filePath, T data)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, JsonSerializer.Serialize(data));
                Console.WriteLine($"Data написано в {filePath}");
            }
            else
            {
                string jsonData = File.ReadAllText(filePath);
                Console.WriteLine($"Data прочитана в {filePath}: {jsonData}");
            }
        }

    }
    static void CreateFiles()
    {
        string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string testFolder = Path.Combine(userFolder, "C: \\Users\\m2307938");

        
        Directory.CreateDirectory(testFolder);

        
        string filePath1 = Path.Combine(testFolder, "task_1.json");
        string filePath2 = Path.Combine(testFolder, "task_2.json");

        
        if (!File.Exists(filePath1))
        {
            File.Create(filePath1).Close();
        }

        if (!File.Exists(filePath2))
        {
            File.Create(filePath2).Close();
        }
    }
}




