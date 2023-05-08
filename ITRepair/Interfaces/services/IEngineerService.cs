using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITRepair.Dtos;

namespace ITRepair.Interfaces.services
{
    public interface IEngineerService
    {
        IEnumerable<EngineerDto> GetAllEngineers();
        CustomerDto GetEngineerById(string id);
        CustomerDto GetEngineerByName(string name);
        void CreateEngineer(EngineerForCreation engineer);
        void UpdateEngineer(EngineerForUpdate engineer);
    }

    public class EngineerForUpdate
    {
    }

    public class EngineerForCreation
    {
    }
}