namespace CourseStore.Common.Domain.Entitties
{
    public interface IHasKey<T>
    {
        T Id { get; set; }
    }
}
