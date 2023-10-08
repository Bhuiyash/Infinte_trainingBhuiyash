using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//code based test 2 - Bhuiyash Kumar, date- 19/9/23

/*Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which
 * takes grade as an input and checks whether student passed the course or not.  
Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed(grade) method
For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. 
For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
Test the above by creating appropriate objects

 */

namespace Csharp_codebased_Test2
{
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public int Grade;
       public abstract bool Ispassed(int grade);
    }
    class Undergraduate : Student
    {
        public Undergraduate(string Name, int StudentId, int Grade)
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.Grade = Grade;
        }
        public override bool Ispassed(int grade)
        {
            return (grade > 70) ? true : false;
        }
    }
    class Grad: Student
    {
        public Grad(string Name, int StudentId, int Grade)
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.Grade = Grade;
        }
        public override bool Ispassed(int grade)
        {
            return (grade > 80) ? true : false;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate("Bhuiyash",123,90);
            Undergraduate undergraduate1 = new Undergraduate("Rohan", 124, 50);
            Grad grad = new Grad("Bhuiyash", 123, 90);
            Grad grad1 = new Grad("Rohan", 124, 70);
           
        }
    }
}
