using CourseStore.Core.Domain.Courses.Dtoes;
using CourseStore.Core.Domain.Courses.Queries;

namespace CourseStore.Core.Domain.Courses.Repositories
{
    public interface ICourseQuery
    {
        public List<CourseListDto> Query(GetCourseList query);
    }
}
