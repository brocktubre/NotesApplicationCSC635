using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplicationCSC635.Models
{
    public enum Name
    {
        BD, TD, IMP
    }
    public class Category
    {
        public int ID { get; set; }
        public Name? Name { get; set; }

        public static implicit operator Category(int v)
        {
            throw new NotImplementedException();
        }
    }
}
