// See https://aka.ms/new-console-template for more information
using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    // Virtual method: Alt sınıflar tarafından override edilecek
    public virtual double CalculateBonus()
    {
        return 0; // Temel sınıfta bonus yok
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary:C}, Department: {Department}");
    }
}

// Manager sınıfı
class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    // Bonus hesaplama: Maaşın %20'si
    public override double CalculateBonus()
    {
        return Salary * 0.2;
    }
}

// Developer sınıfı
class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    // Bonus hesaplama: Maaşın %10'u
    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

// Program sınıfı (Main metodu burada)
class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ahmet Yılmaz", 10000, "Yönetim", 5);
        Developer developer = new Developer(2, "Mehmet Demir", 8000, "Yazılım", "Backend Developer");

        // Bilgileri ekrana yazdır
        manager.DisplayInfo();
        Console.WriteLine($"Bonus: {manager.CalculateBonus():C}\n");

        developer.DisplayInfo();
        Console.WriteLine($"Bonus: {developer.CalculateBonus():C}");
    }
}

