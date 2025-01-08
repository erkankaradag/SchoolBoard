using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBoard
{
    public class Person
    {
        public string Name { get; set; } // Public özellik
        public string Surname { get; set; } // Public özellik
        public DateTime DateBirth { get; set; } // Public özellik
            }
            set
            {
                Name = value;
            }
        }
        private string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        private DateTime DateBirth
        {
            get
            {
                return DateBirth;
            }
            set
            {
                DateBirth = value;
            }
        }
    }
}
