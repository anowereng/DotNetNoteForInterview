using System;

namespace Expression_bodies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(15);
            person.FirstName = "     anower     ";
            person.LastName = "    ullah";



            Console.WriteLine(person.ToString());  

            Console.WriteLine(person.FirstName.Length);
            Console.WriteLine(person.LastName.Length);
            Console.WriteLine(person.FullName.Length);
        }
    }

    public class Person
    {
        public Person(int age) => Age = age;
        private string _lastName;
        private string _firstName;

        public string FirstName { get => _firstName; set=>_firstName = value.Trim(); }
        public int Age { get; set; }
        public string LastName { get => _lastName; set => _lastName = value.Trim(); }



        public string FullName => (FirstName + LastName).Trim(); 

        public override string ToString() => $"{FirstName} {LastName}";

    }
}
