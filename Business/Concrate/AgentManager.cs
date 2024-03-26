using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class AgentManager : IAgentService
    {
        IAgentDal _agentDal;

        public AgentManager(IAgentDal agentDal)
        {
            _agentDal = agentDal;
        }

        public void Add(Agent agent)
        {
            _agentDal.Add(agent);
        }

        public void Delete(Agent agent)
        {
            _agentDal.Delete(agent);
        }

        public List<Agent> GetAll()
        {
            return new List<Agent>(_agentDal.GetAll());
        }

        public Agent GetById(int id)
        {
            return _agentDal.Get(a => a. Id == id);
        }

        public void Update(Agent agent)
        {
            _agentDal.Update(agent);
        }
    }
}
