namespace Lesson8ex1
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;


        static IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };


        static void Main(string[] args)
        {
            var yearAfter1900 = from y in stemPeople
                                where y.BirthYear > 1900
                                select y;
            Console.WriteLine("people who are born after 1900\n");
            foreach (var entry in yearAfter1900)
            {
                Console.WriteLine(entry.Name + " " + entry.BirthYear + "\n");
            }


            var doubleLInName = from p in stemPeople
                                where p.Name.Count(c => c == 'l') == 2
                                select p;
            Console.WriteLine("names with 2 'l'");
            foreach (var entry in doubleLInName)
            {
                Console.WriteLine(entry.Name + "\n");
            }


            var After1950 = from y in stemPeople
                            where y.BirthYear > 1950
                            select y;
            int Count = After1950.Count();
            Console.WriteLine($"Number of people with a birthday after 1950: {Count}" + "\n");



            var entry1920to2000 = from d in stemPeople
                                  where d.BirthYear >= 1920 && d.BirthYear <= 2000
                                  select d;
            Console.WriteLine("People between 1920 - 2000");
            int count = 0;
            foreach (var entry in entry1920to2000)
            {
                count++;
                Console.WriteLine($"{count}: " + entry.Name + "\n");
            }
            Console.WriteLine(count);


            var sortBirthYear = from y in stemPeople
                                orderby y.BirthYear ascending
                                select y;
            //stemPeople.OrderBy(y => y.BirthYear);
            Console.WriteLine("people sorted by birth year from unknown to latest: \n");
            foreach (var entry in sortBirthYear)
            {
                Console.WriteLine(entry.Name + " " + entry.BirthYear + "\n");
            }


            var deathYear = from dY in stemPeople
                            where dY.DeathYear > 1960 && dY.DeathYear < 2015
                            select dY;
            Console.WriteLine("Deaths > 1960 and < 2015 in ascending name order: \n");
            foreach (var death in deathYear)
            {
                Console.WriteLine(death.Name + " " + death.DeathYear + "\n");
            }
        }
    }
}
