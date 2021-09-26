using System;



namespace LabAssignment6
{
    class StudentStructure
    {
        static void Main()
        {
            Student myStudent = new Student(58, "Rachana", "Female", 9876543210);
            Console.WriteLine(myStudent.Display());
            Console.ReadLine();
        }
    }
}
