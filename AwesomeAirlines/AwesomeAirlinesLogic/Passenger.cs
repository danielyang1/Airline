﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class Passenger
    {
        public string Name;
        public string Age;
        public string Email;

        public Passenger(string name, string age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
    }
}
