// See https://aka.ms/new-console-template for more information
// LR 8, задания номер 1, 3, 5, 7, 11, 14
using System.Diagnostics.Metrics;

class Program
{
    public static void Main(string[] args)
    {
        //Task1 task1 = new Task1();
        //task1.counter_of_letters();            //Work

        //Task3 task3 = new Task3();
        //task3.fiftycheck();                    //work

        //Task5 task5 = new Task5();
        //task5.counter_of_letters();            //work

        //Task7 task7 = new Task7();
        //task7.rootchecker();                   //work

        Task11 task11 = new Task11();
        task11.surnamesorter();                  //work        //"Иванов,Петров,Смирнов,Соколов,Кузнецов,Попов,Лебедев,Волков,Козлов,Новиков,Иванова,Петров,Смирнова"    

        //Task14 task14 = new Task14();
        //task14.summer();                       //work

    }
    public abstract class Task()
    {

        private string _alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private int[] counter = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private string text_input = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме.Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга.Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны" ;
        public string text { get { return text_input; } }
        public int[] Counter { get { return counter; } }
        public string Alphabet { get { return _alphabet; } }
        public void inputtext(string text)
        {
            this.text_input = text.ToLower();
        }

        public virtual void WriteMessage()
        {
            Console.WriteLine("");
        }
    }


    public class Task1 : Task
    {
        public void counter_of_letters()

        {
            char[] wordsA = text.ToCharArray();
            char[] rusmas = Alphabet.ToCharArray();        
            int[] counter = Counter;
            
            for (int i = 0; i < wordsA.Length; i++)
            {
                for (int j = 0; j < rusmas.Length - 1; j++)
                {
                    if (wordsA[i] == Alphabet[j])
                    {
                        counter[j] = counter[j] + 1;
                    }
                }
            }
            
            for(int i = 0;i < rusmas.Length; i++)
            {
                double x = (double)counter[i] / wordsA.Length;
                Console.Write("Частота встречаемости {0}: {1}\n ", Alphabet[i],x);
                
            }
            foreach (char c in counter)
            {
                
            }
            
            Console.ReadLine();
        }

    }

    public class Task3 : Task
    {
        public void fiftycheck()
        {
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries); ;
            string currentLine = "";
            foreach (string word in words)
            {
                if ((currentLine + word).Length < 50)
                {
                    // Добавляем слово к текущей строке
                    if (currentLine.Length == 0)
                    {
                        currentLine += word;
                    }
                    else
                    {
                        currentLine += " " + word;
                    }
                }
                else
                {
                    // Выводим текущую строку и начинаем новую
                    Console.WriteLine(currentLine);
                    currentLine = word;
                }
            }
            // Выводим последнюю строку
            Console.WriteLine(currentLine);
        }

    }

    public class Task5 : Task
    {

        public void counter_of_letters()
        {
            string[] words = text.Split(new char[] {' ', ',', '.', '-' }, StringSplitOptions.RemoveEmptyEntries) ;

            int[] letterFrequency = new int[32];

            char[] Alphabet1 = Alphabet.ToCharArray();

            // Подсчитываем частоту каждой буквы
            foreach (string word in words)
            {
                if (word.Length > 0 && char.IsLetter(word[0]))
                {
                    for (int i = 0; i < Alphabet.Length; i++)
                    {
                        if (word[0] == Alphabet[i])
                        {
                            letterFrequency[i]++;
                        }
                    }

                    
                }
            }


            // Сортируем массив по частоте букв в порядке убывания с помощью сортировки пузырьком
            for (int i = 0; i < letterFrequency.Length; i++)
            {
                for (int j = 0; j < letterFrequency.Length - 1; j++)
                {
                    if (letterFrequency[j] < letterFrequency[j + 1])
                    {
                        int temp = letterFrequency[j];
                        letterFrequency[j] = letterFrequency[j + 1];
                        letterFrequency[j + 1] = temp;

                        char temp1 = Alphabet1[j];
                        Alphabet1[j] = Alphabet1[j + 1];
                        Alphabet1[j + 1 ] = temp1;
                    }
                }
            }

            // Печатаем буквы в порядке убывания частоты
            Console.WriteLine("Буквы, на которые начинаются слова в тексте, в порядке убывания частоты их употребления:");
            for (int i = 0; i < 32; i++)
            {
                if (letterFrequency[i] > 0)
                {
                    Console.WriteLine($"{Alphabet1[i]}: {letterFrequency[i]}");
                }
            }
        }
    }

    public class Task7 : Task
    {
        string root = "Грец";
        public void rootchecker()
        {
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries); //требуемый разделитель
            foreach (string word in words)
            {
                if (word.Contains(root))
                    Console.WriteLine(word);
            }
        }

    }

    public class Task11 : Task
    {
        public void surnamesorter()
        {
            string[] Surname = text.Split(new char[] {',',' ','.','-','(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            //foreach(string surname in Surname)
            //{
            //    foreach(char c in surname)
            //    {
            //        if (surname[c] < surname[c] + 1)
            //        {
            //            
            //        }

            //    }
            //}
            for (int i = 0; i < Surname.Length - 1; i++)
                for (int j = 0; j < Surname.Length - 2; j++)
                {
                    if (Surname[i][0] < Surname[j][0])
                    {
                        string temp = Surname[i];
                        Surname[i] = Surname[j];
                        Surname[j] = temp;
                    }
                }
            foreach (string word in Surname)
            {
                Console.WriteLine(word);
            }

        }

    }

    public class Task14 : Task
    {
        public void summer()
        {
            string[] words = text.Split(new char[] { ' ', ',', '.','-','(',')' }, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;
            foreach (string word in words)
            {
                
                foreach (char chars in word)
                {
                    if (Char.IsDigit(word[0]))
                    {
                        
                        k += int.Parse(word);
                        break;
                        
                    }
                }

            }
            Console.WriteLine("Сумма цифр в тексте - {0}",k);


        }


    }

}




