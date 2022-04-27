using CourseStore.Core.Domain.Courses.Entities;
using MediatR;

namespace CourseStore.Core.Domain.Courses.Commands
{
    public class UpdatePrice : IRequest<Course>
    {
        public int Id { get; set; }
        public int Price { get; set; }
    }
}
