using ITRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Implementations.Repository
{
    public static class RepositoryContext
    {
        public static List<Customer> Customers { get; set; }

        public static List<Engineer> Engineers { get; set; }

        public static List<Repair> Repairs { get; set; }   

        public static List<Equipment> Equipments { get; set; } 
    }
}
