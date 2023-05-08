using ITRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Interfaces.Repository
{
    public interface IEngineerRepository
    {
        Task<IEnumerable<Engineer>> GetEngineers();
        Task<Engineer> GetEngineerById(string id);

        Task<Engineer> GetEngineerByName(string name);
        Task CreateEngineer(Engineer engineer);
        Task UpdateEngineer(Engineer engineer);
    }
}
