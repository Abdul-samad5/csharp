using ITRepair.Entities;
using ITRepair.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Implementations.Repository
{
    public class EngineerRepository : IEngineerRepository
    {

        public void CreateEngineer(Engineer engineer) => RepositoryContext.Engineers.Add(engineer);

        public IEnumerable<Engineer> GetAllEngineers() => RepositoryContext.Engineers.ToList();

        public Customer GetEngineerById(string id) 
            => RepositoryContext.Engineers.FirstOrDefault(x => x.EngineerId.Equals(id));

        public Customer GetEngineerByName(string name) 
            => RepositoryContext.Engineers.FirstOrDefault(x => x.FirstName.Equals(name));

        public Task<IEnumerable<Engineer>> GetEngineers()
        {
            throw new NotImplementedException();
        }

        public void UpdateEngineer(string id, Engineer engineer)
        {
            var engineerForUpdate = RepositoryContext.Engineers.FirstOrDefault(x => x.EngineerId.Equals(id));
            engineerForUpdate.FirstName = engineer.FirstName;
            engineerForUpdate.LastName = engineer.LastName;
            engineerForUpdate.Specialism = engineer.Specialism;
             engineerForUpdate.Address = engineer.Address;
        }

        public Task UpdateEngineer(Engineer engineer)
        {
            throw new NotImplementedException();
        }

        Task IEngineerRepository.CreateEngineer(Engineer engineer)
        {
            throw new NotImplementedException();
        }

        Task<Engineer> IEngineerRepository.GetEngineerById(string id)
        {
            throw new NotImplementedException();
        }

        Task<Engineer> IEngineerRepository.GetEngineerByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
