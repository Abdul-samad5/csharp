using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Entities
{
    public class Repair
    {
        public string RepairId { get; set; } = Guid.NewGuid().ToString();
        public string RepairDetails { get; set; }
        public string CustumerNumber { get; set; }
        public DateTime DateInWorkshop { get; set; }
        public DateTime DateOutWorkshop { get; set; }
        public string RepairDescription { get; set; }
        public string EngineerId { get; set; }
        public decimal Cost { get; set; }
        public char Complete { get; set; }
    }
}
