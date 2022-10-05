using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItAssignment.Models
{
    public class Person
    {
        //Fields
        private readonly int id;
        private string firstName;
        private string lastName;

        public Person()
        {
        }

        //Constructor
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Properties
        public int Id { get { return id; } }
        public string FirstName 
        { 
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                else 
                { 
                    firstName = value; 
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    lastName = value;
                }
            }
        }
        
    }
}
