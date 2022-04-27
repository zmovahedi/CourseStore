using CourseStore.Common.ApplicatinService;
using CourseStore.Common.Domain.Repositories;
using CourseStore.Core.Domain.Courses.Commands;
using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Courses.Repositories;
using CourseStore.Core.Domain.Courses.ValueObjects;

namespace CourseStore.Core.ApplicationService.Courses.CommandHandlers
{
    public class CreateCourseHandler : ICommandHandler<CreateCourse>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCourseHandler(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
        {
            _courseRepository = courseRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Handle(CreateCourse command)
        {
            if (_courseRepository.Exist(command.Title))
                throw new Exception("Course with this title already exist");

            var cousre = new Course(command.Title, command.ShortDescription, new CoursePrice(command.Price));
            _courseRepository.Create(cousre);
            _unitOfWork.SaveChanges();

        }
    }
}
