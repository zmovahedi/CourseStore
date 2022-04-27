namespace CourseStore.Common.ApplicatinService
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}
