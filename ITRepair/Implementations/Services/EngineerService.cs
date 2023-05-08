using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITRepair.Dtos;
using ITRepair.Interfaces.Repository;
using ITRepair.Interfaces.services;

namespace ITRepair.Implementations.Services
{
    public class EngineerService : IEngineerService
    {
        private readonly IEngineerRepository _engineerRepository;
        public EngineerService(IEngineerRepository engineerRepository) => _engineerRepository = engineerRepository;

        public void CreateEngineer(EngineerForCreation engineer) =>
            _engineerRepository.CreateEngineer(new Entities.Engineer
            {
                FirstName = engineer.FirstName,
                LastName = engineer.LastName,
                Address = engineer.Address,
                Specialism = engineer.Specialism

            });

        public void CreateEngineer(EngineerForCreation engineer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAllEngineers() =>
            _engineerRepository.GetAllEngineers().Select(x => new EngineerDto
            {
                EngineerId = x.EngineerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber
            });

        public IEnumerable<EngineerDto> GetAllEngineers()
        {
            throw new NotImplementedException();
        }

        public EngineerDto GetEngineerById(string id)
        {
            var engineer = _engineerRepository.GetEngineerById(id);
            return new EngineerDto
            {
                EngineerId = engineer.EngineerId,
                FirstName = engineer.FirstName,
                LastName = engineer.LastName,
                Address = engineer.Address,
                PhoneNumber = engineer.PhoneNumber
            };
        }

        public EngineerDto GetEngineerByName(string name)
        {
            throw new NotImplementedException();
        }

        public EngineerDto GetEngineerById(string id)
        {
            throw new NotImplementedException();
        }

        public EngineerDto GetEngineerByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerForUpdate customer) =>
            _engineerRepository.UpdateEngineer(engineer.EngineerId, new Entities.Engineer
            {
                FirstName = engineer.FirstName,
                LastName = engineer.LastName,
                Address = engineer.Address,
                Specialism = engineer.Specialism
            });

        public void UpdateEngineer(EngineerForUpdate engineer)
        {
            throw new NotImplementedException();
        }
    }
}