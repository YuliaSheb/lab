﻿using System;
using System.Linq;
namespace laba5
{
    public class Programmer : Student
    {
        public Programmer(string university, string faculty, string hometown,
                          string name, string surname, int age)
                 : base(university, faculty, hometown, name, surname, age)
        {
        }
        public override string ToString()
        {
            return "Student: name-" + Name + "  surname-" + Surname + "  age-" + Age + "\n" +
                  "country-" + Country + "  weight-" + Weight + "  height-" + Height + "\t"+
            "\nuniversity- " + University + "  faculty-" + Faculty + "  hometown-" + Hometown;
        }
    }
}
