using _18Aug_Task2.Models;
using System;

namespace _18Aug_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Enter name and surname:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter group id:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(fullName, groupNo, age);
            if (Student.CheckFullname(fullName) && Student.CheckGroupNo(groupNo) && age != 0)
            {
                student.ShowInfo();
            }
            else 
            {
                Console.WriteLine("Wrong input!!!");
                Menu();
            }
                

        }
       


    }
}
