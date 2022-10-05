using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItAssignment.Models
{
    public class Todo
    {
        //Fields
        private readonly int id;
        private string description;
        private bool done;
        private Person assignee;

        //Constructor
        public Todo(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        //Properties
        public int Id { get { return id; } }
        public string Description { 
            get { return description; }  
            set { description = value; } 
        }
        public bool Done { 
            get { return done; } 
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

    }
}
