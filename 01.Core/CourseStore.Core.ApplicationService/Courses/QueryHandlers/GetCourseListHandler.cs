using CourseStore.Common.ApplicatinService;
using CourseStore.Core.Domain.Courses.Dtoes;
using CourseStore.Core.Domain.Courses.Queries;
using CourseStore.Core.Domain.Courses.Repositories;

namespace CourseStore.Core.ApplicationService.Courses.QueryHandlers
{
    public class GetCourseListHandler : IQueryHandler<GetCourseList, List<CourseListDto>>
    {
        private readonly ICourseQuery _courseQuery;

        public GetCourseListHandler(ICourseQuery courseQuery)
        {
            _courseQuery = courseQuery;
        }

        public List<CourseListDto> Handle(GetCourseList query)
        {
            return _courseQuery.Query(query);
        }
    }
}
