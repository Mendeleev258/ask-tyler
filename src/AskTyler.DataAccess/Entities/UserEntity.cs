using System.ComponentModel.DataAnnotations.Schema;
using AskTyler.DataAccess.Entities.Primitives;

namespace AskTyler.DataAccess.Entities;

public class UserEntity : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    
    public string PasswordHash { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public string Bio { get; set; } = string.Empty;
    
    public int UserRating { get; set; } = 0;

    public Role Role { get; set; } = Role.Guest;

    public virtual ICollection<QuestionEntity> Questions { get; set; } = [];
    
    public virtual ICollection<AnswerEntity> Answers { get; set; } = [];

    // Foreign keys
    public int CountryId { get; set; } = 0;
    
    public CountryEntity? Country { get; set; }
}