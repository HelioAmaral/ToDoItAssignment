using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItAssignment.Data
{
    public class TodoSequencer
    {
        private static int todoId;

        public static int NextTodoId()
        {
            todoId++;
            return todoId;
        }

        public static int Reset()
        {
            return todoId = 0;
        }
    }
}
