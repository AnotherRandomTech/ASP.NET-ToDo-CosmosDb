using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Data.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
    }
}
