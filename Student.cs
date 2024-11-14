namespace Case_Opgave
{
    /// <summary>
    /// Klasse der repræsenterer en elev med navn og alder.
    /// </summary>
    public class Student : IPerson
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        /// <summary>
        /// Opretter en elev med fornavn, efternavn og alder.
        /// </summary>
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
