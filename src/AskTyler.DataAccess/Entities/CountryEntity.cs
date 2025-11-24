using System.ComponentModel.DataAnnotations.Schema;
using AskTyler.DataAccess.Entities.Primitives;

namespace AskTyler.DataAccess.Entities;

public class CountryEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    
    public virtual ICollection<UserEntity> Users { get; set; } = [];
}