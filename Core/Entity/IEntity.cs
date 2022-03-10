namespace Core
{
     public interface IEntity<IDType> : IEntity
    {
        IDType Id { get; set; }
    }

    public interface IEntity
    {
        string CreatedBy { get; set; }
        DateTimeOffset? CreationDate { get; set; }
        string ModifiedBy { get; set; }
        DateTimeOffset? ModificationDate { get; set; }
        byte[] RowVersion { get; set; }
        Guid? CreatedById { get; set; }
        Guid? ModifiedById { get; set; }
    }
}