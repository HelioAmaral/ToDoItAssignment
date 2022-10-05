using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItAssignment.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int NextPersonId()
        {
            personId++;
            return personId;
        }

        public static int Reset()
        {
            return personId = 0;
        }

    }
}
