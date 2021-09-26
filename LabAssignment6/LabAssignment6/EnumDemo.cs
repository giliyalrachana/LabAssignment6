using System;


namespace LabAssignment6
{
    // This program demo. how to use enum in Assignment 6
    class EnumDemo
    {
        static void Main()
        {
            Console.WriteLine($"{CityNames.India}=CityNames.India.GetHashCode()");
           // Console.WriteLine($"{ZipCodes.India}={Convert.ToInt32(ZipCodes.India)}");
           
            var names = Enum.GetValues(typeof(CityNames));
            foreach (var name in names)
            {
                Console.WriteLine($"{name}={name.GetHashCode()}");
            }
            Employee employee = new Employee();
            Console.WriteLine(employee.GetEmp(1000, "Rachana", Gender.Female));

            Console.ReadLine();



        }
    }
}

