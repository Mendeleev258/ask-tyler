using System.ComponentModel.DataAnnotations.Schema;

namespace AskTyler.DataAccess.Entities;

[Table(name: "countries")]
public class CountryEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    
    public virtual ICollection<UserEntity> Users { get; set; } = [];
}