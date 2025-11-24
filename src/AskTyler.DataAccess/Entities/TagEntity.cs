using System.ComponentModel.DataAnnotations.Schema;
using AskTyler.DataAccess.Entities.Primitives;

namespace AskTyler.DataAccess.Entities;


public class TagEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<QuestionEntity> Questions { get; set; } = [];
}