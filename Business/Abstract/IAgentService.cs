using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAgentService
    {
        void Add(Agent agent);
        void Delete(Agent agent);
        void Update(Agent agent);
        List<Agent> GetAll();
        Agent GetById(int id);
    }
}
