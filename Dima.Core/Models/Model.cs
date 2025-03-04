using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Models
{
    public abstract class Model
    {
        [Key]
        public long Id { get; set; }
    }
}
