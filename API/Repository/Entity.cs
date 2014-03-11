using System.ComponentModel.DataAnnotations.Schema;

namespace Investments.Repository
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; } 
    }
}