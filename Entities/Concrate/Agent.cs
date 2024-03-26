using Core.Entities;

namespace Entities.Concrate
{
    public class Agent : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }


    }
}


