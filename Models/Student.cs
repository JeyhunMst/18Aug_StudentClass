using System;
using System.Collections.Generic;
using System.Text;

namespace _18Aug_Task2.Models
{
    class Student
    {
        private static string GroupNo { get; set; }
        private static string Fullname { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 170)
                {
                    _age = value;
                }
            }
        }





        public Student(string fullname, string groupno, int age)
        {
            if (CheckFullname(fullname) && CheckGroupNo(groupno))
            {
                Fullname = fullname;
                GroupNo = groupno;
                Age = age;
            }

        }
        public static bool CheckGroupNo(string group)
        {
            if (group.Length == 4 && Char.IsUpper(group[0]))
            {
                int count = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (Char.IsDigit(group[i]))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    return true;
                }
                return false;

            }
            return false;
        }
        public static bool CheckFullname(string fullName)
        {
            bool flag = false;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (Char.IsDigit(fullName[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ')
                {
                    flag = true;
                    break;
                }


            }
            if (flag == true)
            {
                string[] nameAndSur = fullName.Split();

                //for (int i = 0; i < nameAndSur.Length; i++)
                //{
                //    string value = nameAndSur[i];
                //    StringBuilder word = new StringBuilder();
                //    word.Append(Char.ToUpper(value[0]));
                //    word.Append(value.Substring(1).ToLower());
                //    value = word.ToString();
                //    nameAndSur[i] = value;


                //}
                int count = 0;
                for (int i = 0; i < nameAndSur.Length; i++)
                {
                    string value = nameAndSur[i];
                    if (Char.IsUpper(value[0]))
                    {
                        count++;
                    }
                }
                if (count == nameAndSur.Length - 1)
                {
                    return true;
                }
                else
                    return false;



            }
            else
                return false;
            //for (int i = 0; i < fullName.Length; i++)
            //{
            //    if (Char.IsDigit(fullName[i]))
            //    {
            //        return false;
            //    }           
            //}
            //for (int i = 0; i < fullName.Length; i++)
            //{
            //    if (fullName[i] == ' ')
            //    {
            //        break;
            //    }
            //    else
            //        return false;

            //}
            //if (Char.IsUpper(fullName[0]))
            //{
            //    int indexOf = fullName.IndexOf(' ');
            //    if (Char.IsUpper(fullName[indexOf + 1]))
            //    {
            //        return true;
            //    }

            //}
            //return false;












        }
        public void ShowInfo()
            {
                Console.WriteLine($"Name and Surname:{Fullname} \n Group number:{GroupNo} \n Age:{Age}");
            }

        }
    
}
