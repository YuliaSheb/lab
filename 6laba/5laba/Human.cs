using System;
namespace laba5
{
    public class Human 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public Specialty Specialty { get; set; }
        public Type Type{ get; set; }
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Specialty = Specialty.Programming;
            Type = Type.Student;
            Country = "Belarus";
            Weight = 50.0;
            Height = 155;
        }
        public Human(string name, string surname, int age, string country, Specialty specialty, Type type, double weight, int heightr)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Specialty = specialty;
           Type = type;
            Country = country;
            Weight = weight;
        }
        int _value_lab;
        public Human(int value_lab)
        {
            _value_lab = 2 *  value_lab;
        }
        public int Time { get { return _value_lab; } }
        public void Lab(int value_lab) { _value_lab = 2 * value_lab; }
        public void CompareTo()
        {
            if (_value_lab > 186 * 24) Console.WriteLine("Alas, you did not have time to do all the laboratory tests!");
            else Console.WriteLine("Congratulations, you managed to complete all the labs!");
        }
    }
}
