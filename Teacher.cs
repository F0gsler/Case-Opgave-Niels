namespace Case_Opgave
{
    /// <summary>
    /// Klasse der repræsenterer en lærer med navn.
    /// </summary>
    public class Teacher : IPerson
    {
        public string FirstName { get; }
        public string LastName { get; }
        /// <summary>
        /// Opretter en lærer med fornavn og efternavn.
        /// </summary>
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
