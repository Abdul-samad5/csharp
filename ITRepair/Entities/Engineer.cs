using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Entities
{
    public class Engineer
    {
        internal object Address;

        public string EngineerId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialism { get; set; }
         public string Address { get; set; }
    }
}
