using System.Text.Json;

namespace Companies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var director = new JobTitle
                {
                    Name = "Директор",
                    SalaryBonus = 3
                };
                var boss = new JobTitle
                {
                    Name = "Начальник",
                    SalaryBonus = 2.5
                };
                var leading = new JobTitle
                {
                    Name = "Ведущий",
                    SalaryBonus = 2
                };
                var senior = new JobTitle
                {
                    Name = "Старший",
                    SalaryBonus = 1.5
                };
                var middle = new JobTitle
                {
                    Name = "",
                    SalaryBonus = 1
                };
                var junior = new JobTitle
                {
                    Name = "Стажёр",
                    SalaryBonus = 0.5
                };
                var directorIT = new Developer
                {
                    Name = "Директор IT компании",
                    JobTitle = director,
                    Experience = 10,
                    Salary = 120000,
                    ProjectsAmount = 150,
                    Rank = 5,
                    Bonus = 30000
                };
                var bossIT = new Developer
                {
                    Name = "Начальник отдела разработки",
                    JobTitle = boss,
                    Experience = 8,
                    Salary = 90000,
                    ProjectsAmount = 100,
                    Rank = 4,
                    Bonus = 15000
                };
                var leadingIT = new Developer
                {
                    Name = "Ведущий разработчик",
                    JobTitle = leading,
                    Experience = 6,
                    Salary = 75000,
                    ProjectsAmount = 50,
                    Rank = 3,
                    Bonus = 12500
                };
                var seniorIT = new Developer
                {
                    Name = "Старший разработчик",
                    JobTitle = senior,
                    Experience = 3,
                    Salary = 60000,
                    ProjectsAmount = 25,
                    Rank = 2,
                    Bonus = 10000
                };
                var middleIT = new Developer
                {
                    Name = "Разработчик",
                    JobTitle = middle,
                    Experience = 1,
                    Salary = 45000,
                    ProjectsAmount = 10,
                    Rank = 1,
                    Bonus = 7500
                };
                var juniorIT = new Developer
                {
                    Name = "Помощник разработчика",
                    JobTitle = junior,
                    Experience = 0,
                    Salary = 30000,
                    ProjectsAmount = 5,
                    Rank = 0,
                    Bonus = 6000
                };
                var directorManager = new Manager
                {
                    Name = "Диретор продающий компании",
                    JobTitle = director,
                    Experience = 10,
                    Salary = 150000,
                    ProjectsAmount = 250,
                    Rank = 5,
                    Bonus = 40000
                };
                var bossManager = new Manager
                {
                    Name = "Начальник отдела продаж",
                    JobTitle = boss,
                    Experience = 8,
                    Salary = 100000,
                    ProjectsAmount = 175,
                    Rank = 4,
                    Bonus = 36000
                };
                var leadingManager = new Manager
                {
                    Name = "Ведущий продавец",
                    JobTitle = leading,
                    Experience = 6,
                    Salary = 80000,
                    ProjectsAmount = 140,
                    Rank = 3,
                    Bonus = 20000
                };
                var seniorManager = new Manager
                {
                    Name = "Старший продавец",
                    JobTitle = senior,
                    Experience = 3,
                    Salary = 60000,
                    ProjectsAmount = 80,
                    Rank = 2,
                    Bonus = 12000
                };
                var middleManager = new Manager
                {
                    Name = "Продавец",
                    JobTitle = middle,
                    Experience = 1,
                    Salary = 40000,
                    ProjectsAmount = 50,
                    Rank = 1,
                    Bonus = 8000
                };
                var juniorManager = new Manager
                {
                    Name = "Помощник продавца",
                    JobTitle = junior,
                    Experience = 0,
                    Salary = 20000,
                    ProjectsAmount = 25,
                    Rank = 0,
                    Bonus = 4000
                };
                var directorSales = new SalesPerson
                {
                    Name = "Диретор компании по закупкам",
                    JobTitle = director,
                    Experience = 10,
                    Salary = 100000,
                    ProjectsAmount = 200,
                    Rank = 5,
                    Bonus = 25000
                };
                var bossSales = new SalesPerson
                {
                    Name = "Начальник отдела закупок",
                    JobTitle = boss,
                    Experience = 8,
                    Salary = 80000,
                    ProjectsAmount = 100,
                    Rank = 4,
                    Bonus = 20000
                };
                var leadingSales = new SalesPerson
                {
                    Name = "Ведущий специалист по закупкам",
                    JobTitle = leading,
                    Experience = 6,
                    Salary = 70000,
                    ProjectsAmount = 75,
                    Rank = 3,
                    Bonus = 15000
                };
                var seniorSales = new SalesPerson
                {
                    Name = "Старший специалист по закупкам",
                    JobTitle = senior,
                    Experience = 3,
                    Salary = 55000,
                    ProjectsAmount = 80,
                    Rank = 2,
                    Bonus = 10000
                };
                var middleSales = new SalesPerson
                {
                    Name = "Специалист по закупкам",
                    JobTitle = middle,
                    Experience = 1,
                    Salary = 36000,
                    ProjectsAmount = 60,
                    Rank = 1,
                    Bonus = 8000
                };
                var juniorSales = new SalesPerson
                {
                    Name = "Помощник специалиста",
                    JobTitle = junior,
                    Experience = 0,
                    Salary = 22000,
                    ProjectsAmount = 30,
                    Rank = 0,
                    Bonus = 5000
                };

                var compaines = new List<Company>()
            {
                new Company
                {
                    Name = "IT-компаниия ООО \"РазработCheck\"",
                    MaxEmployeeCount = 7,
                    Employees = new List<Employee>()
                    {
                        directorIT,
                        bossIT,
                        leadingIT,
                        seniorIT,
                        middleIT,
                        juniorIT
                    }
                },
                new Company
                {
                    Name = "ООО \"+7 девяток\"",
                    MaxEmployeeCount = 10,
                    Employees = new List<Employee>()
                    {
                        directorManager,
                        bossManager,
                        leadingManager,
                        seniorManager,
                        middleManager,
                        juniorManager
                    }
                },
                new Company
                {
                    Name = "Компания по закупкам ОАО \"Продавай-закупай!\"",
                    MaxEmployeeCount = 12,
                    Employees = new List<Employee>()
                    {
                        directorSales,
                        bossSales,
                        leadingSales,
                        seniorSales,
                        middleSales,
                        juniorSales
                    }
                }
            };
                var myJsonSerializer = new MyJsonSerializer();
                myJsonSerializer.Write(compaines, "raw_data.json");
                var sysAdminIT = new Developer
                {
                    Name = "Системный администратор",
                    JobTitle = middle,
                    Experience = 2,
                    Salary = 50000,
                    ProjectsAmount = 50,
                    Rank = 1,
                    Bonus = 10000
                };
                if (compaines[0].Employees.Count + 1 <= compaines[0].MaxEmployeeCount)
                {
                    compaines[0].Hire(sysAdminIT);
                }
                else
                {
                    throw new Exception("В компании слишком много сотрудников!");
                }
                myJsonSerializer.Write(compaines, "data.json");
                for (int i = 0; i < compaines[2].Employees.Count; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        var employe = compaines[2].Employees[i];
                        compaines[2].Fire(employe);
                        i--;
                    }
                }
                myJsonSerializer.Write(compaines, "new_data.json");

                var rawJsonCompanies = myJsonSerializer.Read("raw_data.json");
                foreach (var company in rawJsonCompanies)
                {
                    Console.WriteLine($"Наименование компании: {company.Name}. Количество вакансий: {company.MaxEmployeeCount}. Сотрудники: ");
                    foreach (var employee in company.Employees)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
                var jsonCompanies = myJsonSerializer.Read("data.json");
                foreach (var company in jsonCompanies)
                {
                    Console.WriteLine($"Наименование компании: {company.Name}. Количество вакансий: {company.MaxEmployeeCount}. Сотрудники: ");
                    foreach (var employee in company.Employees)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
                var newJsonCompanies = myJsonSerializer.Read("new_data.json");
                foreach (var company in newJsonCompanies)
                {
                    Console.WriteLine($"Наименование компании: {company.Name}. Количество вакансий: {company.MaxEmployeeCount}. Сотрудники: ");
                    foreach (var employee in company.Employees)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
                Console.ReadLine();

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }

    public struct JobTitle
    {
        public string Name { get; set; }
        public double SalaryBonus { get; set; }
        public JobTitle()
        {

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public JobTitle JobTitle { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public Employee() 
        {
            
        }

        public override string ToString()
        {
            return $"Должность: {JobTitle.Name} {Name}, опыт работы: {Experience}, оклад: {Salary}";
        }
    }

    public class Manager: Employee, IPayble
    {
        public int ProjectsAmount { get; set; }
        public int Rank { get; set; }
        public int Bonus { get; set; }

        public double CalculateSalary()
        {
            return Salary + Bonus * JobTitle.SalaryBonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", количество проектов: {ProjectsAmount}, ранг: {Rank}";
        }
    }
    public class Developer : Employee, IPayble
    {
        public int ProjectsAmount { get; set; }
        public int Rank { get; set; }
        public int Bonus { get; set; }

        public double CalculateSalary()
        {
            return Salary + Bonus * JobTitle.SalaryBonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", количество проектов: {ProjectsAmount}, ранг: {Rank}";
        }
    }
    public class SalesPerson : Employee, IPayble
    {
        public int ProjectsAmount { get; set; }
        public int Rank { get; set; }
        public int Bonus { get; set; }

        public double CalculateSalary()
        {
            return Salary + Bonus * JobTitle.SalaryBonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", количество проектов: {ProjectsAmount}, ранг: {Rank}";
        }
    }

    public interface IPayble
    {
        public double CalculateSalary();
    }

    public partial class Company
    {
        public string Name { get; set; }
        public int MaxEmployeeCount { get; set; }
        public IList<Employee> Employees { get; set; }
        public Company()
        {
            Employees = new List<Employee>();
        }

        public void Hire(Employee employee)
        {
            Employees.Add(employee);
        }

        public void Fire(Employee employee)
        {
            Employees.Remove(employee);
        }
    }

    public abstract class MySerializer
    {
        public abstract IList<Company> Read(string fileName);

        public abstract void Write(IList<Company> companies, string fileName);
    }

    public class MyJsonSerializer : MySerializer
    {
        public override IList<Company> Read(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    return JsonSerializer.Deserialize<IList<Company>>(File.ReadAllText(fileName)) ?? new List<Company>();
                }
                else
                {
                    throw new Exception("Файл не найден!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Не удалось прочитать файл! Причина: {ex.Message}");
            }
        }

        public override void Write(IList<Company> companies, string fileName)
        {
            try
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(companies));
            }
            catch (Exception ex)
            {
                throw new Exception($"Запись в файл не удалась. Причина: {ex.Message}");
            }
        }
    }
}
