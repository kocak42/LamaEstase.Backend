using Business.Abstract;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class StructureManager : IStructureService
    {
        IStructureDal _structureDal;

        public StructureManager(IStructureDal structureDal)
        {
            _structureDal = structureDal;
        }

        public void Add(Structure structure)
        {
            _structureDal.Add(structure);
        }

        public void Delete(Structure structure)
        {
            _structureDal.Delete(structure);
        }

        public List<Structure> GetAll()
        {
           return new List<Structure>(_structureDal.GetAll());
        }

        public Structure GetById(int id)
        {
            return _structureDal.Get(s =>s.Id  == id);
        }

        public void Update(Structure structure)
        {
            _structureDal.Update(structure);
        }
    }
}
