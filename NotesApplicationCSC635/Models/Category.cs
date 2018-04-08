using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplicationCSC635.Models
{
    public enum Name
    {
        BD, // Birthday
        TD, // Todo
        IMP // Important
    }
    public class Category
    {
        public int ID { get; set; }
        public Name? Name { get; set; }
    }
}
