using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Fifth
{
    public class Factory
    {
        public int EmployeeCode { get; set; }
        public string LastName { get; set; }
        public int DepartmentNumber { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Bonus
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    public class Program
    {
        private List<Factory> employees;
        private List<Bonus> bonuses;
        /// <summary>
        /// Main() реалізує демонстраційний приклад роботи програми
        /// </summary>
        private static void Main(string[] args)
        {
            Program program = new Program();

            int minimumAge = 30; 

            program.InitializeData();

            program.TaskA(minimumAge);

            Console.WriteLine();

            program.TaskB();

            Console.WriteLine();

            program.TaskC();

            Console.ReadLine(); 
        }


        /// <summary>
        /// InitializeData() ініціалізує дані працівників та бонуси.
        /// </summary>
        public void InitializeData()
        {
            employees = new List<Factory>
            {
                new Factory { EmployeeCode = 1, LastName = "Іваненко", DepartmentNumber = 1, Position = "Менеджер", Salary = 5000, DateOfBirth = new DateTime(1980, 1, 1) },
                new Factory { EmployeeCode = 2, LastName = "Петренко", DepartmentNumber = 1, Position = "Інженер", Salary = 4000, DateOfBirth = new DateTime(1985, 2, 2) },
                new Factory { EmployeeCode = 3, LastName = "Коваленко", DepartmentNumber = 2, Position = "Аналітик", Salary = 4500, DateOfBirth = new DateTime(1983, 3, 3) },
                new Factory { EmployeeCode = 4, LastName = "Бондаренко", DepartmentNumber = 4, Position = "Прибиральник", Salary = 3800, DateOfBirth = new DateTime(1990, 4, 4) },
                new Factory { EmployeeCode = 5, LastName = "Ткаченко", DepartmentNumber = 5, Position = "Тестувальник", Salary = 3500, DateOfBirth = new DateTime(1988, 5, 5) },
                new Factory { EmployeeCode = 6, LastName = "Мельниченко", DepartmentNumber = 6, Position = "Дизайнер", Salary = 4200, DateOfBirth = new DateTime(1982, 6, 6) },
                new Factory { EmployeeCode = 7, LastName = "Ковальчук", DepartmentNumber = 7, Position = "Менеджер", Salary = 4800, DateOfBirth = new DateTime(1987, 7, 7) },
                new Factory { EmployeeCode = 8, LastName = "Білоус", DepartmentNumber = 8, Position = "Інженер", Salary = 4100, DateOfBirth = new DateTime(1984, 8, 8) },
                new Factory { EmployeeCode = 9, LastName = "Лисенко", DepartmentNumber = 9, Position = "Аналітик", Salary = 6000, DateOfBirth = new DateTime(1986, 9, 9) },
                new Factory { EmployeeCode = 10, LastName = "Павленко", DepartmentNumber = 10, Position = "Маркетолог", Salary = 3900, DateOfBirth = new DateTime(1991, 10, 10) },
                new Factory { EmployeeCode = 11, LastName = "Савченко", DepartmentNumber = 15, Position = "Сантехнік", Salary = 3600, DateOfBirth = new DateTime(1989, 11, 11) },
                new Factory { EmployeeCode = 12, LastName = "Морозенко", DepartmentNumber = 12, Position = "Дизайнер", Salary = 4300, DateOfBirth = new DateTime(1981, 12, 12) },
                new Factory { EmployeeCode = 13, LastName = "Григоренко", DepartmentNumber = 13, Position = "Менеджер", Salary = 7000, DateOfBirth = new DateTime(1980, 1, 13) },
                new Factory { EmployeeCode = 14, LastName = "Мазур", DepartmentNumber = 14, Position = "Інженер", Salary = 4200, DateOfBirth = new DateTime(1985, 2, 14) },
                new Factory { EmployeeCode = 15, LastName = "Тимошенко", DepartmentNumber = 15, Position = "Сантехнік", Salary = 4700, DateOfBirth = new DateTime(1983, 3, 15) },
                new Factory { EmployeeCode = 16, LastName = "Пономаренко", DepartmentNumber = 16, Position = "Розробник", Salary = 4000, DateOfBirth = new DateTime(1990, 4, 16) },
                new Factory { EmployeeCode = 17, LastName = "Шевченко", DepartmentNumber = 17, Position = "Тестувальник", Salary = 3700, DateOfBirth = new DateTime(1988, 5, 17) },
                new Factory { EmployeeCode = 18, LastName = "Марченко", DepartmentNumber = 18, Position = "Дизайнер", Salary = 4400, DateOfBirth = new DateTime(1982, 6, 18) },
                new Factory { EmployeeCode = 19, LastName = "Шаповаленко", DepartmentNumber = 2, Position = "Менеджер", Salary = 5000, DateOfBirth = new DateTime(1987, 7, 19) },
                new Factory { EmployeeCode = 20, LastName = "Калініченко", DepartmentNumber = 20, Position = "Копірайтер", Salary = 4300, DateOfBirth = new DateTime(1984, 8, 20) },
            };


            bonuses = new List<Bonus>
            {
                new Bonus { Code = 1, Date = new DateTime(2023, 1, 15), Amount = 1000 },
                new Bonus { Code = 2, Date = new DateTime(2023, 2, 20), Amount = 500 },
                new Bonus { Code = 3, Date = new DateTime(2023, 3, 10), Amount = 750 },
                new Bonus { Code = 4, Date = new DateTime(2023, 4, 5), Amount = 300 },
                new Bonus { Code = 5, Date = new DateTime(2023, 5, 8), Amount = 1200 },
                new Bonus { Code = 6, Date = new DateTime(2023, 6, 25), Amount = 900 },
                new Bonus { Code = 7, Date = new DateTime(2023, 7, 19), Amount = 600 },
                new Bonus { Code = 8, Date = new DateTime(2023, 8, 7), Amount = 1500 },
                new Bonus { Code = 9, Date = new DateTime(2023, 9, 14), Amount = 400 },
                new Bonus { Code = 10, Date = new DateTime(2023, 10, 30), Amount = 800 },
                new Bonus { Code = 11, Date = new DateTime(2023, 11, 12), Amount = 1100 },
                new Bonus { Code = 12, Date = new DateTime(2023, 12, 8), Amount = 650 },
                new Bonus { Code = 13, Date = new DateTime(2024, 1, 5), Amount = 950 },
                new Bonus { Code = 14, Date = new DateTime(2024, 2, 17), Amount = 1300 },
                new Bonus { Code = 15, Date = new DateTime(2023, 3, 22), Amount = 550 },
                new Bonus { Code = 16, Date = new DateTime(2024, 4, 9), Amount = 1700 },
                new Bonus { Code = 17, Date = new DateTime(2024, 5, 3), Amount = 950 },
                new Bonus { Code = 18, Date = new DateTime(2024, 6, 28), Amount = 700 },
                new Bonus { Code = 19, Date = new DateTime(2024, 7, 11), Amount = 1400 },
                new Bonus { Code = 20, Date = new DateTime(2024, 8, 29), Amount = 1000 }
            };
        }


        /// <summary>
        /// TaskA() реалізує завдання А: виводить середню зарплату працівників у відділі, вік яких більше або рівний заданому мінімальному віку.
        /// </summary>
        public void TaskA(int minimumAge)
        {
            var result = employees
                .Where(employee => CalculateAge(employee.DateOfBirth) >= minimumAge)
                .GroupBy(employee => employee.DepartmentNumber)
                .Select(departmentGroup => new
                {
                    DepartmentNumber = departmentGroup.Key,
                    AverageSalary = departmentGroup.Average(e => e.Salary)
                });

            foreach (var department in result)
            {
                Console.WriteLine($"Department: {department.DepartmentNumber}, Average Salary: {department.AverageSalary}");
            }
        }

        /// <summary>
        /// TaskB() реалізує завдання B: виводить без повторів назви посад, працівники яких у поточному році отримали премії не більше двох разів.
        /// </summary>
        public void TaskB()
        {
            var result = employees
                .Join(bonuses, employee => employee.EmployeeCode, bonus => bonus.Code, (employee, bonus) => new { Employee = employee, Bonus = bonus })
                .GroupBy(x => x.Employee.Position)
                .Where(group => group.Count() <= 2 && group.Any())
                .Select(group => group.Key);

            var distinctPositions = result.Distinct();

            foreach (var position in distinctPositions)
            {
                Console.WriteLine($"Position: {position}");
            }
        }

        /// <summary>
        /// TaskC() реалізує завдання C: Виводить  інформації про працівників у вигляді XML-елемента employees у такому
        /// форматі: кореневий елемент<employees>, у який вкладена послідовність елементів
        /// <employee>, кожний з яких має атрибути name, job та salary та містить у собі
        /// елемент <bonuses>, який містить послідовність елементів <bonus>, кожен з яких
        /// містять дані про розмір та дату премії. На основі даних XML-елемента employees
        /// знайти та вивести прізвища працівників з найбільшим сумарним заробітком (оклад +
        /// сумарна премія) за один місяць.
        /// </summary>
        public void TaskC()
        {
            var result = new XElement("employees",
                from employee in employees
                select new XElement("employee",
                    new XAttribute("name", employee.LastName),
                    new XAttribute("job", employee.Position),
                    new XAttribute("salary", employee.Salary),
                    new XElement("bonuses",
                        from bonus in bonuses
                        where bonus.Code == employee.EmployeeCode
                        select new XElement("bonus",
                            new XAttribute("amount", bonus.Amount),
                            new XAttribute("date", bonus.Date.ToString("yyyy-MM-dd")))
                    )
                )
            );

            Console.WriteLine(result.ToString());

            var topEarners = result.Elements("employee")
               .Where(e => e.Attribute("salary") != null && e.Element("bonuses") != null)
               .OrderByDescending(e => (double)e.Attribute("salary") + e.Element("bonuses").Elements("bonus").Sum(b => (double)b.Attribute("amount")))
               .Select(e => e.Attribute("name").Value);
            Console.WriteLine();
            Console.WriteLine("Top earners:");

            foreach (var (index, name) in topEarners.Select((name, index) => (index + 1, name)))
            {
                var employeeElement = result.Elements("employee").FirstOrDefault(e => e.Attribute("name").Value == name);
                var salary = double.Parse(employeeElement.Attribute("salary").Value);
                var bonusesSum = employeeElement.Element("bonuses").Elements("bonus").Sum(b => double.Parse(b.Attribute("amount").Value));
                var totalEarnings = salary + bonusesSum;

                Console.WriteLine($"{index}. {name} - {totalEarnings}");
            }

        }

        /// <summary>
        /// CalculateAge() вираховує поточний вік працівника.
        /// </summary>
        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
