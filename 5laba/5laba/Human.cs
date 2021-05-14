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
    }
}
