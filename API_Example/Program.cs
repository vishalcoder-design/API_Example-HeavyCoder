namespace API_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is Vishal laptop Code
            //Chnages in rupesh branch
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("1:Add Employee");
                Console.WriteLine("2:Update Employee");
                Console.WriteLine("3:Delete Employee");
                Console.WriteLine("4:Display Employee");
                Console.WriteLine("5:Display Employees");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Employee ea = new Employee();

                        Console.WriteLine("Enter the Id");
                        ea.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name");
                        ea.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Age");
                        ea.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Salary");
                        ea.Salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the City");
                        ea.City = Console.ReadLine(); 
                        EmployeeService.add(ea); break;


                    case 2:
                        Employee ed = new Employee();

                        Console.WriteLine("Enter the Id");
                        ed.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name");
                        ed.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Age");
                        ed.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Salary");
                        ed.Salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the City");
                        ed.City = Console.ReadLine();
                        EmployeeService.update(ed); break;



                    case 3:
                        Console.WriteLine("Enter the Id ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        EmployeeService.delete(Id); break;
                    case 4: EmployeeService.display(101); break;
                    case 5: EmployeeService.diplayAll(); break;
                    default: Console.WriteLine(" Your choise is wrong"); break;
                }
            }
        }
    }
    class Employee
    {
        public int Id;
        public string Name;
        public int Age;
        public double Salary;
        public string City;
        public Employee()
        {
        }
        public Employee(int Id, string name, int age, double salary, string city)
        {
            this.Id = Id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.City = city;
        }
    }
    class EmployeeService
    {
        public static List<Employee> es = new List<Employee>()
        {
            new Employee(101,"Amol",25,26000, "Pune"),

        };


        public static void add(Employee emp)
        {
            es.Add(emp);
            Console.WriteLine("add succesefully");
        }
        public static void update(Employee emp)
        {
            foreach (Employee e in es)
            {
                if (e.Id == emp.Id)
                {
                    e.Name = emp.Name;
                    e.Age = emp.Age;
                    e.Salary = emp.Salary;
                    e.City = emp.City;
                }
            }
            Console.WriteLine("update succesefully");
        }
        public static void delete(int Id)
        {
            bool flag = false;
            for (int i = 0; i < es.Count; i++)
            {
                if (es[i].Id == Id)
                {
                    es.RemoveAt(i);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Does not exist");
                return;
            }
            Console.WriteLine("delete succesefully");
        }
        public static void display(int id)
        {
            Console.WriteLine("Single Employee");
        }
        public static void diplayAll()
        {

            Console.WriteLine("Employee List");
            foreach (Employee emp in es)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Age + " " + emp.Salary+ " " + emp.City);
            }
        }
    }
}
