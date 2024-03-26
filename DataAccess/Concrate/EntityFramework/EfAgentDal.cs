
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfAgentDal : EfEntityRepositoryBase<Agent, LamaEstaseContext>, IAgentDal
    {
    }

}
