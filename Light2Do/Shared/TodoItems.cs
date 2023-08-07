using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light2Do.Shared
{
    public class TodoItems
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; } 
        public DateTime DateAdded { get; set; } =DateTime.Now;
        public bool IsDone { get; set; }
        public string Author { get; set; } = "КК";
    }
}
