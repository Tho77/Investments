using System.ComponentModel.DataAnnotations.Schema;

namespace Investments.Repository
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}