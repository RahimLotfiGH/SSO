namespace AUA.SSO.DomainEntities.BaseRepo
{ 
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
