using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uplantApi.Models.Generic
{
    public class GenericPerson
    {
        public Guid Id { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String nickname { get; set; }
        public int age { get; set; }
        public String personType  { get; set; }
        
    }
}
