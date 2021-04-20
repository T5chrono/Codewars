using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars.Katas
{
    public class JohnMeeting
    {
        private class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }

            public Person(string name, string surname)
            {
                Name = name.ToUpper();
                Surname = surname.ToUpper();
            }
        }

        public static string Meeting(string s)
        {
            var surnamesAndNames = new List<Person>();

            var peopleArray = s.Split(";");
            foreach (var person in peopleArray)
            {
                var surnameAndName = person.Split(":");
                surnamesAndNames.Add(new Person(surnameAndName[0], surnameAndName[1]));
            }

            var sortedList = surnamesAndNames.OrderBy(p => p.Surname).ThenBy(p => p.Name);
            StringBuilder sb = new StringBuilder();
            foreach (var person in sortedList)
            {
                sb.Append($"({person.Surname}, {person.Name})");
            }

            return sb.ToString();
        }
    }
}
