using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoItAssignment.Models;

namespace ToDoItAssignment.Data
{
    public class TodoService
    {
        private static Todo[] todoArray = new Todo[0];

        public int Size()
        {
            return todoArray.Length;
        }

        public Todo[] FindAll()
        {
            return todoArray;
        }

        public Todo FindById(int todoId)
        {
            return todoArray[todoId];
        }

        /*
        public Todo NewTodoObject(string newObject)
        {

        }
        */

        public void ClearTodoArray()
        {
            todoArray = new Todo[0];
        }
    }
}
