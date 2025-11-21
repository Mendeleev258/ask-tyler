using System.ComponentModel.DataAnnotations.Schema;

namespace AskTyler.DataAccess.Entities;


[Table(name: "tags")]
public class TagEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<QuestionEntity> Questions { get; set; } = [];
}