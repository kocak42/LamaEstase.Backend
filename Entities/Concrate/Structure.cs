using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Structure : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Bathroom { get; set; }
        public int Bedroom { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int BusStop { get; set; }
        public int Area { get; set; }
        public int Income { get; set; }
        public int School { get; set; }
        public int Restaurant { get; set; }
        public string PetPolicy { get; set; }
    }
}


