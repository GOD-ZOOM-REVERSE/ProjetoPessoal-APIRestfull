using System.ComponentModel.DataAnnotations;

namespace ProjetoPessoal.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
