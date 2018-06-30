using System;

class Employee
{
    public string LastName;
    public string FirstName;
    public string CityOfBirth;


    public string this[int index]
    {
        set
        {
            switch (index)
            {
                case 0: LastName = value; break;
                case 1: FirstName = value; break;
                case 2: CityOfBirth = value; break;
                default:
                    throw new ArgumentOutOfRangeException("index");
            }
        }

        get
        {
            switch (index)
            {
                case 0: return LastName;
                case 1: return FirstName;
                case 2: return CityOfBirth;
                default:
                   throw new ArgumentOutOfRangeException("index");
            }
        }
   }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp[0] = "Shusaku";
        emp[1] = "Yusa";
        emp[2] = "Date";

        Console.WriteLine("Last Name :    {0}", emp[0]);
        Console.WriteLine("First Name:    {0}", emp[1]);
        Console.WriteLine("City of Birth: {0}", emp[2]);
    }
}
