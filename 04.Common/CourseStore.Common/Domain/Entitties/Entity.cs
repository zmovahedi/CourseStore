namespace CourseStore.Common.Domain.Entitties
{
    public abstract class Entity<TKey> : IHasKey<TKey>
    {
        public TKey Id { get; set; }
    }
}
