﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string firstname, string lastname, DateTime bithDate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.BirthDate = bithDate;
        }
    }
}
