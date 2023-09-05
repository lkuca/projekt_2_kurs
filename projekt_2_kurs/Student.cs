using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



    public class Student
    {
        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;
        public int year;
        public Student(string name, int age, string city, int year)
        {
            Name = name;
            Age = age;
            _city = city;
        this.year = year;
        }
        public int Year
        {       
           get { return year; } 
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 18) status = "alaealine";
                else status = "täiskasvanud";
            }
        }

        public string GetCity()
        {
            return _city;
        }

        public void showInfo()
        {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(GetCity());
    }
}

    

