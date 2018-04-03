using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplicationCSC635.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOn { get; set; }
        public Category Category { get; set; }
        public bool IsDeleted { get; set; }
        public User User { get; set; }

    }
}
