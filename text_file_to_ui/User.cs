using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    public class User
    {
        public string name;
        public string surname;
        public int birthYear;
        public string city;
        public string faculty;
        public string role;
        public string specificAttribute;
        public string specificAttributeName;

        public User(string name, string surname, int year, string city, string faculty, string role, string attribute, string attributeName)
        {
            this.name = name;
            this.surname = surname;
            this.birthYear = year;
            this.city = city;
            this.faculty = faculty;
            this.role = role;
            this.specificAttribute = attribute;
            this.specificAttributeName = attributeName;
        }
    }
}
