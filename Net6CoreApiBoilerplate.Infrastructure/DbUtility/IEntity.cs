namespace Net6CoreApiBoilerplate.Infrastructure.DbUtility
{
    public interface IEntity
    {
        long Oid { get; set; }
    }

    public interface IIdentityEntity
    {
        long Id { get; set; }
    }
}
