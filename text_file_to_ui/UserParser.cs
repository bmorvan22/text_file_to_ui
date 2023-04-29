using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    class UserParser
    {
        public User parseFile(string path)
        {
            return new User("Baptiste", "Morvan", 2000, "Varazdin", "FOI", "student", "Software engineering", "favorite course");
        }
    }
}
