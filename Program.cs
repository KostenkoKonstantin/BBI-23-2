// See https://aka.ms/new-console-template for more information





//Уровень 1. Задание 5 


//struct Student
//{
//    public int mark;
//    public int lost_lesson;
//    public string name;
//    public Student(int mark1, int lost_lesson1, string name1)
//    {
//        this.mark = mark1;
//        this.lost_lesson = lost_lesson1;
//        this.name = name1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //Student temp;
//        //Student[] sp = new Student[5];
//        //int[] marks = new int[5];
//        //Random r = new Random();
//        //for (int i = 0; i < marks.Length; i++)
//        //    marks[i] = r.Next(0, 6);
//        //int[] looses = new int[5];
//        //for (int i = 0; i < looses.Length; i++)
//        //    looses[i] = r.Next(0, 11);
//        //string[] grandnames = new string[5] { "Иванов", "Смирнов", "Соболев", "Калинин", "Джугашвили" };



//        //for (int i = 0; i < sp.Length; i++)
//        //{
//        //    sp[i].mark = marks[i];
//        //    sp[i].lost_lesson = looses[i];
//        //    sp[i].name = grandnames[i];
//        //    //Console.WriteLine("Фамилия {0}, Оценка {1}, Колво пропущенных {2}", sp[i].name, sp[i].mark, sp[i].lost_lesson);

//        //}
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


//        //for (int i = 0; i < sp.Length - 1; i++)
//        //{
//        //    double amax = sp[i].lost_lesson;
//        //    int imax = i;
//        //    for (int j = i + 1; j < sp.Length; j++)
//        //    {
//        //        if (sp[j].lost_lesson > amax)
//        //        {
//        //            amax = sp[j].lost_lesson;
//        //            imax = j;
//        //        }
//        //    }
//        //}
//        for (int i = 1; i < sp.Length; i++)
//        {
//            for (int j = 1; j < sp.Length; j++)
//            {
//                if (sp[j].lost_lesson > sp[j - 1].lost_lesson)
//                {
//                    (sp[j], sp[j - 1]) = (sp[j - 1], sp[j]);
//                }
//            }
//        }

//    for (int i = 0; i < sp.Length; i++)
//        {
//            if (sp[i].mark < 3)
//                Console.WriteLine("Фамилия {0}, Оценка {1}, Количество Пропущенных {2}", sp[i].name, sp[i].mark, sp[i].lost_lesson);
//        }
//    }
//}


//Уровень 2.Задание 1

//struct Student
//{
//    private string Name;
//    public string FirstName;
//    public int mark_exam1;
//    public int mark_exam2;
//    public int mark_exam3;
//    public int mark_exam4;
//    public double score;
//    public Student(string FirstName1,int mark_exam11, int mark_exam22, int mark_exam33, int mark_exam44,int score1)
//    {
//        this.FirstName = FirstName1;
//        this.mark_exam1 = mark_exam11;
//        this.mark_exam2 = mark_exam22;
//        this.mark_exam3 = mark_exam33;
//        this.mark_exam4 = mark_exam44;
//        this.score = score1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student temp;
//        Random r = new Random();
//        Student[] sp = new Student[15];

//        //Marks
//        int[] mark_exam11 = new int[15];
//        for (int i = 0; i < mark_exam11.Length; i++)
//            mark_exam11[i] = r.Next(1, 6);

//        int[] mark_exam22 = new int[15];
//        for (int i = 0; i < mark_exam22.Length; i++)
//            mark_exam22[i] = r.Next(1, 6);

//        int[] mark_exam33 = new int[15];
//        for (int i = 0; i < mark_exam33.Length; i++)
//            mark_exam33[i] = r.Next(1, 6);

//        int[] mark_exam44 = new int[15];
//        for (int i = 0; i < mark_exam44.Length; i++)
//            mark_exam44[i] = r.Next(1, 6);

//        //Surnames
//        string[] FirtsName = new string[15] { "СМИРНОВ", "ИВАНОВ", "КУЗНЕЦОВ", "ПОПОВ", "СОКОЛОВ", "ЛЕБЕДЕВ", "КОЗЛОВ", "НОВИКОВ", "МОРОЗОВ", "ПЕТРОВ", "ВОЛКОВ", "СОЛОВЬЁВ", "ВАСИЛЬЕВ", "ЗАЙЦЕВ", "ПАВЛОВ"};

//        //Student-check

//        //Average score
//        double[] score1 = new double[15];
//        for (int i = 0;i < score1.Length; i++)
//        {
//            score1[i] = (mark_exam11[i] + mark_exam22[i] + mark_exam33[i] + mark_exam44[i]) / 4.0;
//        }

//        //Making a list of Students
//        for(int i = 0;i < sp.Length; i++)
//        {
//            sp[i].FirstName = FirtsName[i];
//            sp[i].mark_exam1 = mark_exam11[i];
//            sp[i].mark_exam2 = mark_exam22[i];
//            sp[i].mark_exam3 = mark_exam33[i];
//            sp[i].mark_exam4 = mark_exam44[i];
//            sp[i].score = score1[i];
//        }

//        //Sort-machine

//        for (int i = 1; i < sp.Length; i++)
//        {
//            for (int j = 1; j < sp.Length; j++)
//            {
//                if (sp[j].score > sp[j - 1].score)
//                {
//                    (sp[j], sp[j - 1]) = (sp[j - 1], sp[j]);
//                }
//            }
//        }

//        for (int i = 0; i < sp.Length; i++)
//        {
//            if (sp[i].score >= 4)
//                Console.WriteLine("фамилия {0}, средний балл {1}. Оценки за экзамены: {2},{3},{4},{5}", sp[i].FirstName, sp[i].score, sp[i].mark_exam1, sp[i].mark_exam2, sp[i].mark_exam3, sp[i].mark_exam4);
//        }



//    }
//}




//Уровень 3.Задание 3

//struct Sportik
//{
//    private string Name;
//    public string Surname;
//    public int Teams;
//    public double result;
//    public int score;
//    public Sportik(string name1,string Surname1,int Teams1,double result1,int score1)
//    {
//        this.Name = name1;
//        this.Surname = Surname1;
//        this.Teams = Teams1;
//        this.result = result1;
//        this.score = score1;
//    }
//}

//struct Team
//{
//    public int score;
//    public int number;
//    public bool firstin;
//    public Team(int score1,int number1,bool fisrtin1)
//    {
//        this .score = score1;
//        this .number = number1;
//        this .firstin = fisrtin1;
//    }
//}

//class Program()
//{
//    static void Main()
//    {
//        Sportik temp;
//        Team temp1;

//        //Characters

//        string[] FirstName = new string[18] { "СМИРНОВ", "ИВАНОВ", "КУЗНЕЦОВ", "ПОПОВ", "СОКОЛОВ", "ЛЕБЕДЕВ", "КОЗЛОВ", "НОВИКОВ", "МОРОЗОВ", "ПЕТРОВ", "ВОЛКОВ", "СОЛОВЬЁВ", "ВАСИЛЬЕВ", "ЗАЙЦЕВ", "ПАВЛОВ","ГАДЖИЕВ","МУРАТОВ","МАМЕДОВ" };
//        double[] Result = new double[] { 7.13, 7.30, 7.40, 7.55, 7.70, 7.90, 7.02, 7.05, 8.02, 8.20, 7.76, 7.21, 7.42, 7.83, 7.93, 7.39 , 7.21, 6.93};

//        //Sorted to team
//        int[] team = new int[18];
//        int count = 0;
//        for (int i = 0; i< FirstName.Length; i++)
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
//        for (int i = 0;i < score.Length; i++)
//        {
//            score[i] = 0;
//        }
            


//        //Making a sportmens 

//        Sportik[] Sp = new Sportik[18];

//        for (int i = 0;i < 18;i++)
//        {
//            Sp[i].Surname = FirstName[i];
//            Sp[i].Teams = team[i];
//            Sp[i].score = score[i];
//            Sp[i].result = Result[i];
//            //Console.WriteLine("Фамилия {0}, Команда {1}, Количество баллов {2}, Результат {3}",Sp[i].Surname, Sp[i].Teams, Sp[i].score, Sp[i].result);

//        }
//        //Sorted results

//        for (int i = 1; i < Sp.Length; i++)
//        {
//            for (int j = 1;j < Sp.Length; j++)
//            {
//                if (Sp[j].result < Sp[j - 1].result)
//                {
//                    (Sp[j - 1], Sp[j]) = (Sp[j], Sp[j - 1]);
//                }
//            }

//        }

//        //Results After Sort
     
//        //Assign score to sportiks
//        int count2 = 0;
//        for (int i = 0;i < 5;i++)
//        {
//            count2++;
//            if (count2 == 1)
//            {
//                Sp[i].score = 5;
//            }
//            if (count2 == 2)
//            {
//                Sp[i].score = 4;

//            }
//            if (count2 == 3)
//            {
//                Sp[i].score = 3;
//            }
//            if (count2 == 4)
//            {
//                Sp[i].score = 2;
//            }
//            if (count2 == 5)
//            {
//                Sp[i].score = 1;
//            }
//        }

//        //Results after sorting and making the score table

//        for (int i = 0; i < Sp.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}, Команда {1}, Количество баллов {2}, Результат {3}", Sp[i].Surname, Sp[i].Teams, Sp[i].score, Sp[i].result);
//        }

//        //

//        int dynamic = 0;
//        int team1 = 0;
//        bool team1sp = false;
//        int team2 = 0;
//        bool team2sp = false;
//        int team3 = 0;
//        bool team3sp = false;
//        for (int i = 0;i < 5; i++)
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
//        spmest[0] = new Team { score = team1,number =  1, firstin = team1sp };
//        spmest[1] = new Team { score = team2, number = 2, firstin = team2sp };
//        spmest[2] = new Team { score = team3, number = 3, firstin = team3sp };

//        for (int i = 1; i < spmest.Length; i++)
//        {
//            for (int j = 1;j < spmest.Length; j++)
//            {
//                if ((spmest[j - 1].score) < spmest[j].score)
//                {
//                    (spmest[j - 1], spmest[j]) = (spmest[j], spmest[j - 1]);
//                }
//            }
//        }

//        for (int i = 0;i < 3; i++)
//        {
//            Console.WriteLine("В данном соревновании победила команда, набравшая {0} очков. Эта команда выступала под номером {1}",spmest[i].score, spmest[i].number);
//        }

       

        

        

    }
}




