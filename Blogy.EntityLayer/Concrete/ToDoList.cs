using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
    public class ToDoList
    {
        public int ToDoListId { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
