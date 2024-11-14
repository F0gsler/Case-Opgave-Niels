using System.Collections.Generic;

namespace Case_Opgave
{
    /// <summary>
    /// Klasse der repræsenterer et fag med lærer og tilknyttede elever.
    /// </summary>
    public class Subject
    {
        public string Name { get; }
        public Teacher Teacher { get; }
        public List<Student> Students { get; }

        /// <summary>
        /// Opretter et fag med navn, lærer og elever.
        /// </summary>

        public Subject(string name, Teacher teacher, List<Student> students)
        {
            Name = name;
            Teacher = teacher;
            Students = students;
        }
    }
}
