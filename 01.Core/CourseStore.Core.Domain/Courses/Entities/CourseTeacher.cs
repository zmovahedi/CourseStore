using CourseStore.Common.Domain.Entitties;

namespace CourseStore.Core.Domain.Courses.Entities
{
    public class CourseTeacher : Entity<int>
    {
        public CourseTeacher(int teacherId, int sortOrder)
        {
            TeacherId = teacherId;
            SortOrder = sortOrder;
        }

        public int TeacherId { get; private set; }
        public int CourseId { get; private set; }
        public int SortOrder { get; private set; }
    }
}
