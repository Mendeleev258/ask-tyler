namespace AskTyler.DataAccess.Entities.Primitives;

public class BaseEntity
{
    public int Id { get; set; }

    public Guid ExternalId { get; set; }
    
    public DateTime CreationTime { get; set; }
    
    public DateTime ModificationTime { get; set; }
}