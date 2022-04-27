using CourseStore.Common.Domain.Repositories;
using CourseStore.Core.Domain.Courses.Commands;
using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Courses.Repositories;
using CourseStore.Core.Domain.Courses.ValueObjects;
using MediatR;

namespace CourseStore.Core.ApplicationService.Courses.CommandHandlers
{
    public class UpdatePriceHandler : IRequestHandler<UpdatePrice, Course>
    {
        private readonly ICourseRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePriceHandler(ICourseRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Course> Handle(UpdatePrice request, CancellationToken cancellationToken)
        {
            Course course = _repository.GetById(request.Id);
            if (course == null)
                throw new Exception($"Course with id: {request.Id} not exist.");
            course.UpdatePrice(new CoursePrice(request.Price));
            await _unitOfWork.SaveChangesAsync();
            return course;
        }
    }
}
