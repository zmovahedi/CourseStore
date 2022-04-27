using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Courses.Repositories;
using CourseStore.Infra.Data.Commands.EF.Contexts;

namespace CourseStore.Infra.Data.Commands.EF.Courses.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseStoreDbContext _context;

        public CourseRepository(CourseStoreDbContext context)
        {
            _context = context;
        }

        public void Create(Course course)
        {
            _context.Courses.Add(course);
        }

        public bool Exist(string title)
        {
            return _context.Courses.Any(c => c.Title == title);
        }

        public Course GetById(int id)
        {
            return _context.Courses.SingleOrDefault(c => c.Id == id);
        }
    }
}
