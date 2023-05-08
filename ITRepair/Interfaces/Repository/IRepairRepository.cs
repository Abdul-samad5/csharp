using ITRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Interfaces.Repository
{
    public interface IRepairRepository
    {
        Task<IEnumerable<Repair>> GetRepairs();
        Task<Repair> GetRepair(string id);
        Task CreateRepair(Repair repair);
        Task UpdateRepair(Repair repair);
    }
}
