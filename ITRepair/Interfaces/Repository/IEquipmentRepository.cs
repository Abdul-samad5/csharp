using ITRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Interfaces.Repository
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetEngineers();
        Task<Equipment> GetEngineerById(string id);

        Task<Equipment> GetEngineerByName(string name);
        Task CreateEngineer(Equipment engineer);
        Task UpdateEngineer(Equipment engineer);
    }
}
