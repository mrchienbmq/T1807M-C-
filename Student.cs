using System;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace Session.Properties
{
    public class test
    {
        public static void Main(String[] args)
        {
            Student st = new Student();
            StudentManager stmn = new StudentManager();
            stmn.inputInfo();
            stmn.showInfo();
            stmn.setAvg();
        }
    }
    public class Student
    {
        public int ID;
        public double averagemark;
        public int age;
        public string classroom;

        public Student(int id, double averagemark, int age, string classroom)
        {
            ID = id;
            this.averagemark = averagemark;
            this.age = age;
            this.classroom = classroom;
        }

        public Student()
        {
            
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public double Averagemark
        {
            get => averagemark;
            set => averagemark = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Classroom
        {
            get => classroom;
            set => classroom = value;
        }

        public virtual void inputInfo()
        {
            
        }

        public virtual void showInfo()
        {
            
        }

        public virtual void setAvg()
        {
            
        }
    }

    public class StudentManager : Student
    {
        
        public override void inputInfo()
        {
            Console.WriteLine("please input info student");
            
            Console.WriteLine("please input ID student");
            ID = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("please input averagemark student");
            averagemark = Convert.ToDouble(Console.ReadLine());
            
            
            Console.WriteLine("please input age student ");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("please input classrom student");
            classroom = Convert.ToString(Console.ReadLine());

        }

        public override void showInfo()
        {
                        
            Console.WriteLine("INFO STUDENT");
            Console.WriteLine("INFO id : "+ID);
            Console.WriteLine("INFO avg : "+averagemark);
            Console.WriteLine("INFO age : "+age);
            Console.WriteLine("INFO Classroom : "+classroom);
        }

        public override void setAvg()
        {
            if (averagemark >= 8.0)
            {
                Console.WriteLine("You have received a very good scholarship.");
            }
            else if(averagemark <8.0)
            {
                Console.WriteLine("You do not receive a scholarship.");
                
            }

        }
    }
    
}