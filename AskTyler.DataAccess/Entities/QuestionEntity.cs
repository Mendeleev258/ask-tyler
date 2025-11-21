using System.ComponentModel.DataAnnotations.Schema;

namespace AskTyler.DataAccess.Entities;


[Table(name: "questions")]
public class QuestionEntity : BaseEntity
{
    public string Title { get; set; } = String.Empty;
    
    public string Text { get; set; } = String.Empty;
    
    public int UserId { get; set; }
    
    public UserEntity? User { get; set; }
    
    public int TagId { get; set; }
    
    public TagEntity? Tag { get; set; }

    public virtual ICollection<AnswerEntity> Answers { get; set; } = [];

    public virtual ICollection<QuestionEntity> Questions { get; set; } = [];
}