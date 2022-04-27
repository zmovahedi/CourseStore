using CourseStore.Common.Domain.Entitties;

namespace CourseStore.Core.Domain.Tags.Entities
{
    public class CourseTag : Entity<int>
    {
        public CourseTag(int courseId)
        {
            CourseId = courseId;
        }

        public int TagId { get; private set; }
        public int CourseId { get; private set; }
    }
}
