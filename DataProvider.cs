using System.Collections.Generic;
using System.Linq;

namespace Case_Opgave
{
    public static class DataProvider
    {
        /// <summary>
        /// Det her er listen af alle elever, hvor den giver dem en value per elev. Vi bruger csv til at seperare values
        /// </summary>
        private static List<Student> students = new List<Student>
        {
            new Student("Andreas", "Lorenzen", 18),
            new Student("Casper", "Clemmensen", 21),
            new Student("Daniel", "Bjerne Jensen", 20),
            new Student("Hjalte", "Moesgaard Leth", 17),    
            new Student("Johan", "Milter Jakobsen", 19),
            new Student("Louis", "Thomas Dao Pedersen", 18),
            new Student("Lukas", "Haugstad Frederiksen", 13),
            new Student("Marcus", "Wahlstrom", 22),
            new Student("Marcus", "Slot Rohr", 19),
            new Student("Marius", "Fogelgren", 18),
            new Student("Mathias", "Altenburg", 23),
            new Student("Patrick", "Gutierrez Fogelstrom", 20),
            new Student("Ramtin", "Akbari", 23),
            new Student("Sebastian", "Tolbol Nielsen", 21),
            new Student("Simon", "Heilbuth", 18),
            new Student("Tobias", "Svarter Hammarkvist", 22),
            new Student("Yosef", "Kasas", 18),
        };

        private static Teacher henrikPaulsen = new Teacher("Henrik V.", "Paulsen");
        private static Teacher nielsOlesen = new Teacher("Niels", "Olesen");
        private static Teacher michaelHansen = new Teacher("Michael Gilbert", "Hansen");
        private static Teacher nikolajFredsoe = new Teacher("Nikolaj Bo", "Fredsoe");


        /// <summary>
        /// Her inde i denne list giver vi "Subjects" value fra elever og lærer 
        /// </summary>
        public static List<Subject> GetSubjects()
        {
            return new List<Subject>
            {
                new Subject("Grundlæggende programmering", henrikPaulsen, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                }),
                new Subject("OOP", nielsOlesen, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                }),
                new Subject("Computerteknologi", michaelHansen, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                }),
                new Subject("Serversikkerhed", nikolajFredsoe, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                }),
                new Subject("Database programmering", michaelHansen, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                }),
                new Subject("Clientside programmering", michaelHansen, new List<Student>
                {
                    students.First(s => s.FirstName == "Andreas" && s.LastName == "Lorenzen"),
                    students.First(s => s.FirstName == "Casper" && s.LastName == "Clemmensen"),
                    students.First(s => s.FirstName == "Daniel" && s.LastName == "Bjerne Jensen"),
                    students.First(s => s.FirstName == "Hjalte" && s.LastName == "Moesgaard Leth"),
                    students.First(s => s.FirstName == "Johan" && s.LastName == "Milter Jakobsen"),
                    students.First(s => s.FirstName == "Louis" && s.LastName == "Thomas Dao Pedersen"),
                    students.First(s => s.FirstName == "Lukas" && s.LastName == "Haugstad Frederiksen"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Wahlstrom"),
                    students.First(s => s.FirstName == "Marcus" && s.LastName == "Slot Rohr"),
                    students.First(s => s.FirstName == "Marius" && s.LastName == "Fogelgren"),
                    students.First(s => s.FirstName == "Mathias" && s.LastName == "Altenburg"),
                    students.First(s => s.FirstName == "Patrick" && s.LastName == "Gutierrez Fogelstrom"),
                    students.First(s => s.FirstName == "Sebastian" && s.LastName == "Tolbol Nielsen"),
                    students.First(s => s.FirstName == "Ramtin" && s.LastName == "Akbari"),
                    students.First(s => s.FirstName == "Simon" && s.LastName == "Heilbuth"),
                    students.First(s => s.FirstName == "Tobias" && s.LastName == "Svarter Hammarkvist"),
                    students.First(s => s.FirstName == "Yosef" && s.LastName == "Kasas")
                })
            };
        }
    }
}
