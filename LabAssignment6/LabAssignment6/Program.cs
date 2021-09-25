using System;


namespace LabAssignment6
{
    class CityInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("City Names\n");
            var city = Enum.GetNames(typeof(CityInfo));
            foreach (var name in city)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine();

            Console.WriteLine("Zip Codes");
            var cityname = Enum.GetValues(typeof(CityInfo));
            foreach (var name in cityname)
            {
                Console.WriteLine($"{name.GetHashCode}");
            }
            Console.WriteLine();


        }
    }
}
