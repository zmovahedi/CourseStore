using CourseStore.Common.Domain.Entitties;
using CourseStore.Core.Domain.Courses.ValueObjects;

namespace CourseStore.Core.Domain.Courses.Entities
{
    public class Course : AggregateRoot<int>
    {
        public Course(string title, string shortDescription, CoursePrice price)
        {
            Title = title;
            ShortDescription = shortDescription;
            Price = price;

            CourseTeachers = new List<CourseTeacher>();
        }

        // TODO: ef error for value objects in ctor
        protected Course()
        { 
        }

        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndTime { get; private set; }
        public CoursePrice Price { get; private set; }
        public string? ImageUrl { get; private set; }
        public List<CourseTeacher> CourseTeachers { get; private set; }

        public void AddTeacherToCourse(int teacherId, int sortOrder)
        {
            CourseTeachers.Add(new CourseTeacher(teacherId, sortOrder));
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void UpdatePrice(CoursePrice price)
        { 
            Price = price;
        }
    }
}
