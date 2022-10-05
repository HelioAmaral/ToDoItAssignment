using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoItAssignment.Models;

namespace ToDoItAssignment.Data
{
    
    public class PeopleService
    {
        private static Person[] personArray = new Person[0];

        public int Size()
        {
            return personArray.Length;
        }

        public Person[] FindAll()
        {
            return personArray;
        }

        public Person FindById(int personId)
        {
            return personArray[personId];
        }

        /*
        public Person NewPersonObject(string newObject)
        {
            return new Person();

        }
        */

        public void ClearPersonArray()
        {
            personArray = new Person[0];
        }
    }
}
