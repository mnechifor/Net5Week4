using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class TestAutoProps
    {
        public string FirstName { get; set; }

        private string lastName_backingField;

        public void set_LastName(string value)
        {
            lastName_backingField = value;
        }

        public string get_LastName()
        {
            return lastName_backingField;
        }

    }
}
