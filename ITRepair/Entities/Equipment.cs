using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Entities
{
    public class Equipment
    {
        public string EquipmentId { get; set; } = Guid.NewGuid().ToString();
        public string EquipmentSerialNumber { get; set; }
        public string Type { get; set; }
        public string Issue { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
