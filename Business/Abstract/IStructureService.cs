using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStructureService
    {
        void Add(Structure structure);
        void Delete(Structure structure);
        void Update(Structure structure);
        List<Structure> GetAll();
        Structure GetById(int id);
    }
}
