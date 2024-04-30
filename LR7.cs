// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;




//Уровень 1. Задание 5 


//public abstract class Student
//{
//    private int mark; //Поля
//    private int lost_lesson;
//    private string name;
//    public Student(int mark1, int lost_lesson1, string name1) //Конструктор инициализировать поля (присваивать значения)
//    {
//        this.mark = mark1;
//        this.lost_lesson = lost_lesson1;
//        this.name = name1;
//    }
//    public int Mark { get { return mark; } }
//    public int Lost_lesson { get { return lost_lesson; } }
//    public string Name { get { return name; } }
//    public virtual void WriteMessage() //Метод
//    {
//        Console.WriteLine("Фамилия {0}, Оценка {1}, Колво пропущенных {2}", Name, Mark, Lost_lesson);
//    }

//}

//public class Mathlessons: Student
//{

//    public Mathlessons(int mark1, int lost_lesson1, string name1)
//        : base(mark1, lost_lesson1, name1)
//    {

//    }
//    public override void WriteMessage()
//    {
//        Console.WriteLine("Предмет математика, Фамилия {0}, Оценка {1}, Колво пропущенных {2}", Name, Mark, Lost_lesson);
//    }

//}

//public class ITlessons : Student
//{

//    public ITlessons(int mark1, int lost_lesson1, string name1)
//        : base(mark1, lost_lesson1, name1)
//    {

//    }
//    public override void WriteMessage()
//    {
//        Console.WriteLine("Предмет информатика, Фамилия {0}, Оценка {1}, Колво пропущенных {2}", Name, Mark, Lost_lesson);
//    }

//}



//class Program
//{
//    static void Main() // Метод мэйн
//    {
//        ITlessons[] spIT = new ITlessons[9];
//        spIT[0] = new ITlessons(4, 6, "Иванов");
//        spIT[1] = new ITlessons(5, 7, "Смирнов");
//        spIT[2] = new ITlessons(3, 3, "Соболев");
//        spIT[3] = new ITlessons(0, 10, "Краснов");
//        spIT[4] = new ITlessons(2, 7, "Джугашвили");
//        spIT[5] = new ITlessons(2, 19, "Миронов");
//        spIT[6] = new ITlessons(3, 3, "Костин");
//        spIT[7] = new ITlessons(2, 12, "Дрожащий");
//        spIT[8] = new ITlessons(5, 0, "Кайфовый");

//        Mathlessons[] spMath = new Mathlessons[9];
//        spMath[0] = new Mathlessons(5, 0, "Иванов");
//        spMath[1] = new Mathlessons(5, 7, "Смирнов");
//        spMath[2] = new Mathlessons(4, 4, "Соболев");
//        spMath[3] = new Mathlessons(2, 11, "Краснов");
//        spMath[4] = new Mathlessons(5, 7, "Джугашвили");
//        spMath[5] = new Mathlessons(5, 0, "Миронов");
//        spMath[6] = new Mathlessons(4, 2, "Костин");
//        spMath[7] = new Mathlessons(3, 7, "Дрожащий");
//        spMath[8] = new Mathlessons(0, 12, "Кайфовый");

//        for (int i = 1; i < spIT.Length; i++)
//        {
//            for (int j = 1; j < spIT.Length; j++)
//            {
//                if (spIT[j].Lost_lesson > spIT[j - 1].Lost_lesson)
//                {
//                    (spIT[j], spIT[j - 1]) = (spIT[j - 1], spIT[j]);
//                }
//            }
//        }

//        for (int i = 1; i < spMath.Length; i++)
//        {
//            for (int j = 1; j < spMath.Length; j++)
//            {
//                if (spMath[j].Lost_lesson > spMath[j - 1].Lost_lesson)
//                {
//                    (spMath[j], spMath[j - 1]) = (spMath[j - 1], spMath[j]);
//                }
//            }
//        }


//        //for (int i = 1; i < 9; i++)
//        //    for (int j = i; j > 0 && sp[j - 1].Lost_lesson > sp[j].Lost_lesson; j--)
//        //    {
//        //        (sp[j - 1], sp[j]) = (sp[j], sp[j - 1]);
//        //        //Student boofer;
//        //        //boofer = sp[j -1];
//        //        //sp[j - 1] = sp[j];
//        //        //sp[j] = boofer;

//        //    }

//        ITlessons val;
//        Mathlessons val1;
//        int ji;
//        for (int i = 1; i < 9; i++)
//        {
//            val = spIT[i];
//            ji = i - 1;
//            while (ji >= 0 && spIT[ji].Lost_lesson > val.Lost_lesson)
//            {
//                spIT[ji + 1] = spIT[ji];
//                ji = ji - 1;
//            }
//            spIT[ji + 1] = val;
//        }
//        for (int i = 1; i < 9; i++)
//        {
//            val1 = spMath[i];
//            ji = i - 1;
//            while (ji >= 0 && spMath[ji].Lost_lesson > val1.Lost_lesson)
//            {
//                spMath[ji + 1] = spMath[ji];
//                ji = ji - 1;
//            }
//            spMath[ji + 1] = val1;
//        }
//        Console.WriteLine("Неуспевающие по");

//        for (int i = 0; i < spIT.Length; i++)
//        {
//            if (spIT[i].Mark < 3)
//                spIT[i].WriteMessage();
//        }
//        Console.WriteLine("Неуспевающие по");
//        for (int i = 0; i < spMath.Length; i++)
//        {
//            if (spMath[i].Mark < 3)
//                spMath[i].WriteMessage();
//        }
//    }
//}


//Уровень 2.Задание 1

//public abstract class Human
//{
//    private string firstname;
//    public string FirstName { get { return firstname; } }
//    public Human(string Firstname1)
//    {
//        firstname = Firstname1;
//    }
//}
//public class Student: Human
//{

//    private int[] marks;
//    private double score;
//    private double student_number;

//    public int[] Marks { get { return marks; } }
//    public double Score { get { return score; } }
//    public double Student_number { get { return student_number; } }


//    public Student(string Firstname1, int[] Marks1, double Student_Number)
//        :base (Firstname1)
//    {
//        student_number = Student_Number;
//        marks = Marks1;
//        for (int i = 0; i < 4; i++)
//        {
//            score += Marks[i];
//        }
//        score /= 4;
//    }

//}
//class Program
//{
//    static void Main()
//    {
//        Random r = new Random();

//        //Surnames
//        string[] FirstName = ["СМИРНОВ", "ИВАНОВ", "КУЗНЕЦОВ", "ПОПОВ", "СОКОЛОВ", "ЛЕБЕДЕВ", "КОЗЛОВ", "НОВИКОВ", "МОРОЗОВ", "ПЕТРОВ", "ВОЛКОВ", "СОЛОВЬЁВ", "ВАСИЛЬЕВ", "ЗАЙЦЕВ", "ПАВЛОВ"];

//        //Marks
//        int[][] Marks2 = [[3, 2, 5, 2], [4, 3, 2, 5], [4, 3, 2, 5], [4, 4, 2, 5], [4, 3, 5, 5], [4, 3, 2, 4], [4, 3, 5, 5], [4, 5, 5, 5], [4, 2, 2, 5], [4, 3, 2, 2], [3, 5, 3, 5], [5, 5, 5, 5], [5, 5, 2, 2], [4, 3, 2, 2], [4, 3, 5, 5]];

//        //Student_number's
//        double[] Numbers = [2307938, 2307939, 23079310, 23079311, 23079312, 23079313, 23079314, 23079315, 23079316, 23079317, 23079318, 23079319, 23079320, 23079321, 23079322, 23079323];

//        //Students
//        Student[] sp = new Student[15];
//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i] = new Student(FirstName[i], Marks2[i], Numbers[i]);
//        }

//        //Sort-machine

//        for (int i = 1; i < sp.Length - 1; i++)
//        {
//            for (int j = 1; j < sp.Length; j++)
//            {
//                if (sp[j].Score > sp[j - 1].Score)
//                {
//                    (sp[j], sp[j - 1]) = (sp[j - 1], sp[j]);
//                }
//            }
//        }

//        for (int i = 0; i < sp.Length; i++)
//        {
//            if (sp[i].Score >= 4)
//                Console.WriteLine("студенческий билет № {0}, фамилия {1}, средний бал {2}",sp[i].Student_number, sp[i].FirstName, sp[i].Score);
//        }
//    }
//}

//Уровень 3.Задание 3

public class Sportik
{
    private string surname;
    private int teams;
    private double Result;
    private int Score;
    public string Surname { get { return surname; } }
    public int Teams { get { return teams; } }
    public double result { get { return Result; } }
    public int score { get { return Score; } }
    public Sportik(string Surname1, int Teams1, double result1)
    {

        surname = Surname1;
        teams = Teams1;
        Result = result1;

    }
}

public abstract class Team
{
    private int Score;
    private int Number;
    private bool Firstin;
    public int score { get { return Score; } }
    public int number { get { return Number; } }
    public bool firstin { get { return Firstin; } }

    public Team(int score1, int number1, bool fisrtin1)
    {
        Score = score1;
        Number = number1;
        Firstin = fisrtin1;
    }
    public virtual void WriteMessage()
    {
        Console.WriteLine("В данном соревновании победила команда, набравшая {0} очков. Эта команда выступала под номером {1}", score, number);
    }

    public static void Winner(Team team1, Team team2)
    {
        if (team1.Score > team2.Score)
        {
            if(team1 is TeamMan)
            {
                Console.WriteLine("В данном соревновании победила мужская команда, набравшая {0} очков. Эта команда выступала под номером {1}", team1.score, team1.number);
            }
            if(team1 is TeamWomen)
            {
                Console.WriteLine("В данном соревновании победила женская команда, набравшая {0} очков. Эта команда выступала под номером {1}", team1.score, team1.number);
            }
        }
        if (team2.Score > team1.Score)
        {
            if (team2 is TeamMan)
            {
                Console.WriteLine("В данном соревновании победила мужская команда, набравшая {0} очков. Эта команда выступала под номером {1}", team2.score, team2.number);
            }
            if (team2 is TeamWomen)
            {
                Console.WriteLine("В данном соревновании победила женская команда, набравшая {0} очков. Эта команда выступала под номером {1}", team2.score, team2.number);
            }
        }
    }
}

public class TeamWomen: Team
{
    public TeamWomen(int score1, int number1, bool fisrtin1)
        :base(score1, number1, fisrtin1)
    {
        
    }
    public override void WriteMessage()
    {
        Console.WriteLine("В данном соревновании победила женская команда, набравшая {0} очков. Эта команда выступала под номером {1}", score, number);
    }
}

public class TeamMan : Team
{
    public TeamMan(int score1, int number1, bool fisrtin1)
        : base(score1, number1, fisrtin1)
    {

    }
    public override void WriteMessage()
    {
        
    }
}



class Program()
{
    static void Main()
    {
        //Characters

        string[] FirstNameMan = new string[18] { "СМИРНОВ", "ИВАНОВ", "КУЗНЕЦОВ", "ПОПОВ", "СОКОЛОВ", "ЛЕБЕДЕВ", "КОЗЛОВ", "НОВИКОВ", "МОРОЗОВ", "ПЕТРОВ", "ВОЛКОВ", "СОЛОВЬЁВ", "ВАСИЛЬЕВ", "ЗАЙЦЕВ", "ПАВЛОВ", "ГАДЖИЕВ", "МУРАТОВ", "МАМЕДОВ" };
        double[] ResultMan = new double[] { 7.13, 7.30, 7.40, 7.55, 7.70, 7.90, 7.02, 7.05, 8.02, 8.20, 7.76, 7.21, 7.42, 7.83, 7.93, 7.39, 7.21, 6.93 };

        string[] FirstNameWoman = new string[18] { "СМИРНОВА", "ИВАНОВА", "КУЗНЕЦОВА", "ПОПОВА", "СОКОЛОВА", "ЛЕБЕДЕВА", "КОЗЛОВА", "НОВИКОВА", "МОРОЗОВА", "ПЕТРОВА", "ВОЛКОВА", "СОЛОВЬЁВА", "ВАСИЛЬЕВА", "ЗАЙЦЕВА", "ПАВЛОВА", "ГАДЖИЕВА", "МУРАТОВА", "МАМЕДОВА" };
        double[] ResultWoman = new double[] { 7.00, 7.21, 7.45, 7.53, 7.10, 7.82, 7.08, 7.05, 8.70, 9.22, 6.76, 12.81, 7.12, 7.82, 7.23, 7.99, 7.81, 6.13 };

        //Sorted to team
        int[] team = new int[18];
        int count = 0;
        for (int i = 0; i < FirstNameMan.Length; i++)
        {
            count++;
            if (count < 7)
                team[i] = 1;
            if (count > 6 & count < 13)
                team[i] = 2;
            if (count > 12)
                team[i] = 3;
        }

        //Making a list with nulls
        int[] score = new int[18];
        for (int i = 0; i < score.Length; i++)
        {
            score[i] = 0;
        }



        //Making a sportmens 

        Sportik[] SpMan = new Sportik[18];
        Sportik[] SpWoman = new Sportik[18];

        for (int i = 0; i < 18; i++)
        {
            SpMan[i] = new Sportik(FirstNameMan[i], team[i], ResultMan[i]);
            SpWoman[i] = new Sportik(FirstNameWoman[i], team[i], ResultWoman[i]);

        }
        //Sorted results

        for (int i = 1; i < SpMan.Length; i++)
        {
            for (int j = 1; j < SpMan.Length; j++)
            {
                if (SpMan[j].result < SpMan[j - 1].result)
                {
                    (SpMan[j - 1], SpMan[j]) = (SpMan[j], SpMan[j - 1]);
                }
            }
        }

        for (int i = 1; i < SpWoman.Length; i++)
        {
            for (int j = 1; j < SpWoman.Length; j++)
            {
                if (SpWoman[j].result < SpWoman[j - 1].result)
                {
                    (SpWoman[j - 1], SpWoman[j]) = (SpWoman[j], SpWoman[j - 1]);
                }
            }
        }

        //Results after sorting and making the score table

        //for (int i = 0; i < SpMan.Length; i++)
        //{
        //    Console.Write("Мужская команда");
        //    Console.WriteLine("Фамилия {0}, Команда {1}, Результат {2}", SpMan[i].Surname, SpMan[i].Teams, SpMan[i].result);
        //    Console.Write("Женская команда");
        //    Console.WriteLine("Фамилия {0}, Команда {1}, Результат {2}", SpWoman[i].Surname, SpWoman[i].Teams, SpWoman[i].result);
        //}




        int dynamic = 0;
        int team1 = 0;
        bool team1sp = false;
        int team2 = 0;
        bool team2sp = false;
        int team3 = 0;
        bool team3sp = false;
        for (int i = 0; i < 5; i++)
        {
            if (i == dynamic)
            {
                if (SpMan[i].Teams == 1)
                {
                    team1 += (5 - dynamic);
                    team1sp = true;

                }
                if (SpMan[i].Teams == 2)
                {
                    team2 += (5 - dynamic);
                    team2sp = true;
                }
                if (SpMan[i].Teams == 3)
                {
                    team3 += (5 - dynamic);
                    team3sp = true;
                }
                dynamic++;
            }
            
        }
        int dynamicw = 0;
        int team1w = 0;
        bool team1spw = false;
        int team2w = 0;
        bool team2spw = false;
        int team3w = 0;
        bool team3spw = false;
        for (int i = 0; i < 5; i++)
        {
            if (i == dynamicw)
            {
                if (SpWoman[i].Teams == 1)
                {
                    team1w += (5 - dynamicw);
                    team1spw = true;

                }
                if (SpWoman[i].Teams == 2)
                {
                    team2w += (5 - dynamicw);
                    team2spw = true;
                }
                if (SpWoman[i].Teams == 3)
                {
                    team3w += (5 - dynamicw);
                    team3spw = true;
                }
                dynamicw++;
            }
        }

        //Make a list with teams

        TeamWomen[] spmest = new TeamWomen[3];
        spmest[0] = new TeamWomen(team1w, 1, team1spw);
        spmest[1] = new TeamWomen(team2w, 2, team2spw);
        spmest[2] = new TeamWomen(team3w, 3, team3spw);

        TeamMan[] spmestm = new TeamMan[3];
        spmestm[0] = new TeamMan(team1, 1, team1sp);
        spmestm[1] = new TeamMan(team2, 2, team2sp);
        spmestm[2] = new TeamMan(team3, 3, team3sp);

        for (int i = 1; i < spmest.Length; i++)
        {
            for (int j = 1; j < spmest.Length; j++)
            {
                if ((spmest[j - 1].score) < spmest[j].score)
                {
                    (spmest[j - 1], spmest[j]) = (spmest[j], spmest[j - 1]);
                }
            }
        }

        for (int i = 1; i < spmestm.Length; i++)
        {
            for (int j = 1; j < spmestm.Length; j++)
            {
                if ((spmestm[j - 1].score) < spmestm[j].score)
                {
                    (spmestm[j - 1], spmestm[j]) = (spmestm[j], spmestm[j - 1]);
                }
            }
        }

        Team.Winner(spmest[0], spmestm[0]);
        
    }
}
