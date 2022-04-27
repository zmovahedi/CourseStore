namespace CourseStore.Common.ApplicatinService
{
    public interface IQueryHandler<TQuery, TResult>
    {
        TResult Handle(TQuery command);
    }
}
