using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AskTyler.DataAccess.Entities;


[Table(name: "answers")]
public class AnswerEntity : BaseEntity
{
    public string Text { get; set; } = string.Empty;

    public int Rating { get; set; } = 0;
    
    // Foreign keys
    public int UserId { get; set; }
    
    public UserEntity? User { get; set; }
    
    public int QusetionId { get; set; }
    
    public QuestionEntity? Question { get; set; }
}