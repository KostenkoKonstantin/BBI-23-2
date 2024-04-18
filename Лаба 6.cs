// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;




//Уровень 1. Задание 5 


//struct Student
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
//    public void WriteMessage() //Метод
//    {
//        Console.WriteLine("Фамилия {0}, Оценка {1}, Колво пропущенных {2}", Name, Mark, Lost_lesson);
//    }

//}

//class Program
//{
//    static void Main() // Метод мэйн
//    {
//        Student[] sp = new Student[9];
//        sp[0] = new Student(4, 6, "Иванов");
//        sp[1] = new Student(5, 7, "Смирнов");
//        sp[2] = new Student(3, 3, "Соболев");
//        sp[3] = new Student(0, 10, "Краснов");
//        sp[4] = new Student(2, 7, "Джугашвили");
//        sp[5] = new Student(2, 19, "Миронов");
//        sp[6] = new Student(3, 3, "Костин");
//        sp[7] = new Student(2, 12, "Дрожащий");
//        sp[8] = new Student(5, 0, "Кайфовый");

//        for (int i = 1; i < sp.Length; i++)
//        {
//            for (int j = 1; j < sp.Length; j++)
//            {
//                if (sp[j].Lost_lesson > sp[j - 1].Lost_lesson)
//                {
//                    (sp[j], sp[j - 1]) = (sp[j - 1], sp[j]);
//                }
//            }
//        }

//        for (int i = 0; i < sp.Length; i++)
//        {
//            if (sp[i].Mark < 3)
//                sp[i].WriteMessage();
//        }
//    }
//}


//Уровень 2.Задание 1
//struct Student
//{
//    private string firstname;
//    private int[] marks;
//    private double score;
//    public string FirstName { get { return firstname; } }
//    public int[] Marks { get { return marks; } }
//    public double Score { get { return score; } }
//    public Student(string Firstname1, int[] Marks1)
//    {
//        firstname = Firstname1;
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

//        //Students
//        Student[] sp = new Student[15];
//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i] = new Student(FirstName[i], Marks2[i]);
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
//                Console.WriteLine("фамилия {0}, средний балл {1}", sp[i].FirstName, sp[i].Score);
//        }
//    }
//}

//Уровень 3.Задание 3

//struct Sportik
//{
//    private string surname;
//    private int teams;
//    private double Result;
//    private int Score;
//    public string Surname { get { return surname; } }
//    public int Teams { get { return teams; } }
//    public double result { get { return Result; } }
//    public int score { get { return Score; } }
//    public Sportik(string Surname1, int Teams1, double result1)
//    {

//        surname = Surname1;
//        teams = Teams1;
//        Result = result1;

//    }
//}

//struct Team
//{
//    public int score;
//    public int number;
//    public bool firstin;
//    public Team(int score1, int number1, bool fisrtin1)
//    {
//        this.score = score1;
//        this.number = number1;
//        this.firstin = fisrtin1;
//    }
//}

//class Program()
//{
//    static void Main()
//    {
//        //Characters

//        string[] FirstName = new string[18] { "СМИРНОВ", "ИВАНОВ", "КУЗНЕЦОВ", "ПОПОВ", "СОКОЛОВ", "ЛЕБЕДЕВ", "КОЗЛОВ", "НОВИКОВ", "МОРОЗОВ", "ПЕТРОВ", "ВОЛКОВ", "СОЛОВЬЁВ", "ВАСИЛЬЕВ", "ЗАЙЦЕВ", "ПАВЛОВ", "ГАДЖИЕВ", "МУРАТОВ", "МАМЕДОВ" };
//        double[] Result = new double[] { 7.13, 7.30, 7.40, 7.55, 7.70, 7.90, 7.02, 7.05, 8.02, 8.20, 7.76, 7.21, 7.42, 7.83, 7.93, 7.39, 7.21, 6.93 };

//        //Sorted to team
//        int[] team = new int[18];
//        int count = 0;
//        for (int i = 0; i < FirstName.Length; i++)
//        {
//            count++;
//            if (count < 7)
//                team[i] = 1;
//            if (count > 6 & count < 13)
//                team[i] = 2;
//            if (count > 12)
//                team[i] = 3;
//        }

//        //Making a list with nulls
//        int[] score = new int[18];
//        for (int i = 0; i < score.Length; i++)
//        {
//            score[i] = 0;
//        }



//        //Making a sportmens 

//        Sportik[] Sp = new Sportik[18];

//        for (int i = 0; i < 18; i++)
//        {
//            Sp[i] = new Sportik(FirstName[i], team[i], Result[i]);

//        }
//        //Sorted results

//        for (int i = 1; i < Sp.Length; i++)
//        {
//            for (int j = 1; j < Sp.Length; j++)
//            {
//                if (Sp[j].result < Sp[j - 1].result)
//                {
//                    (Sp[j - 1], Sp[j]) = (Sp[j], Sp[j - 1]);
//                }
//            }
//        }

//        //Results after sorting and making the score table

//        for (int i = 0; i < Sp.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}, Команда {1}, Результат {2}", Sp[i].Surname, Sp[i].Teams, Sp[i].result);
//        }

//        int dynamic = 0;
//        int team1 = 0;
//        bool team1sp = false;
//        int team2 = 0;
//        bool team2sp = false;
//        int team3 = 0;
//        bool team3sp = false;
//        for (int i = 0; i < 5; i++)
//        {
//            if (i == dynamic)
//            {
//                if (Sp[i].Teams == 1)
//                {
//                    team1 += (5 - dynamic);
//                    team1sp = true;

//                }
//                if (Sp[i].Teams == 2)
//                {
//                    team2 += (5 - dynamic);
//                    team2sp = true;
//                }
//                if (Sp[i].Teams == 3)
//                {
//                    team3 += (5 - dynamic);
//                    team3sp = true;
//                }
//                dynamic++;
//            }
//        }

//        //Make a list with teams

//        Team[] spmest = new Team[3];
//        spmest[0] = new Team { score = team1, number = 1, firstin = team1sp };
//        spmest[1] = new Team { score = team2, number = 2, firstin = team2sp };
//        spmest[2] = new Team { score = team3, number = 3, firstin = team3sp };

//        for (int i = 1; i < spmest.Length; i++)
//        {
//            for (int j = 1; j < spmest.Length; j++)
//            {
//                if ((spmest[j - 1].score) < spmest[j].score)
//                {
//                    (spmest[j - 1], spmest[j]) = (spmest[j], spmest[j - 1]);
//                }
//            }
//        }

//        for (int i = 0; i < 1; i++)
//        {
//            Console.WriteLine("В данном соревновании победила команда, набравшая {0} очков. Эта команда выступала под номером {1}", spmest[i].score, spmest[i].number);
//        }
//    }
//}










