using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class Passenger
    {
        public string Name;
        public int Age;
        public string Email;

        public Passenger(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
    }
}
