using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string name;
        private string email;
        private int age;


        public Person(string name,int age) : this(name, age, null)
        {
        }

        public Person(string name,int age,string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name can not be null");
                }
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Name can not be empty");
                }
                this.name = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value == "" || !value.Contains("@"))
                    {
                        throw new ArgumentException("Email can not be empty and must contains @");
                    }
                }
                this.email = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be between 1 and 100");
                }
                this.age = value;
            }
                
         }

        public override string ToString()
        {
            string personInfo = String.Format("Name: {0}. Age: {1}. Email: {2}.", this.Name, this.Age, this.Email ?? "no email"); 
            return personInfo;
            
        }
    }

}
