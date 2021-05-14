namespace laba5
{
    public class Student : Human
    {
        public string University { get; private set; }
        public string Faculty { get; private set; }
        public string Hometown { get; private set; }
        public Student(string university, string faculty, string hometown,
                       string name, string surname, int age)
            : base(name, surname, age)
        {
            University = university;
            Faculty = faculty;
            Hometown = hometown;
        }
    }
}