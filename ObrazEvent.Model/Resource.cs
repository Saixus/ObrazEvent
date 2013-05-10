using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazEvent.Model
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Service Service { get; set; }
        public Event Event { get; set; }
    }
}
