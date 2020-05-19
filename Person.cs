using System;
using System.Collections.Generic;
using System.Text;

namespace First_and_reverse_team
{
    class Person
    {
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.salary = salary;
        }

        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }
        
    }
}
