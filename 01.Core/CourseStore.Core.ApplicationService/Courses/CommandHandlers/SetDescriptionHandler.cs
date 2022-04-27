using CourseStore.Common.ApplicatinService;
using CourseStore.Common.Domain.Repositories;
using CourseStore.Core.Domain.Courses.Commands;
using CourseStore.Core.Domain.Courses.Repositories;

namespace CourseStore.Core.ApplicationService.Courses.CommandHandlers
{
    public class SetDescriptionHandler : ICommandHandler<SetDescription>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SetDescriptionHandler(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
        {
            _courseRepository = courseRepository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(SetDescription command)
        {
            var course = _courseRepository.GetById(command.Id);
            if (course == null)
                throw new Exception($"Course with id: {command.Id} not exist!");
            course.SetDescription(command.Description);
            _unitOfWork.SaveChanges();
        }
    }
}
