using CourseStore.Core.Domain.Courses.Dtoes;
using CourseStore.Core.Domain.Courses.Queries;
using CourseStore.Core.Domain.Courses.Repositories;
using CourseStore.Infra.Data.Commands.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CourseStore.Infra.Data.Commands.EF.Courses.Repositories
{
    public class CourseQuery : ICourseQuery
    {
        private readonly CourseStoreDbContext _context;

        public CourseQuery(CourseStoreDbContext context)
        {
            _context = context;
        }

        public List<CourseListDto> Query(GetCourseList query)
        {
            var courseQuery = _context.Courses.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(query.Title))
                courseQuery = courseQuery.Where(c => c.Title.Contains(query.Title));

            return courseQuery
                .Select(c => new CourseListDto 
                {
                    Title = c.Title,
                    Price = c.Price.Price,
                    ShortDescription = c.ShortDescription,
                    ImageUrl = c.ImageUrl
                }).ToList();
        }
    }
}
