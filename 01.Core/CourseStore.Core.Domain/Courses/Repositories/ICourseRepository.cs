using CourseStore.Core.Domain.Courses.Entities;

namespace CourseStore.Core.Domain.Courses.Repositories
{
    public interface ICourseRepository
    {
        Course GetById(int id);
        bool Exist(string title);
        void Create(Course course);
    }
}
