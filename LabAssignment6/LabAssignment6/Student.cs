using System;
 

namespace LabAssignment6
{
        struct Student
        {
            int studentRollNo;
            string studentName;
            string studentGender;
            int studentMobileNo;

            public Student(int studentRollNo, string studentName, string studentGender, int studentMobileNo)
            {
                this.studentRollNo = studentRollNo;
                this.studentName = studentName;
                this.studentGender = studentGender;
                this.studentMobileNo = studentMobileNo;
            }

            public string Display()
            {
                return $"RollNo={this.studentRollNo}\nName={this.studentName}\nGender={this.studentGender}\nMobileNo={this.studentMobileNo}";
            }

        }
    }
