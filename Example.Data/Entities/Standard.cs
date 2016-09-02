using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Data.Entities
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
