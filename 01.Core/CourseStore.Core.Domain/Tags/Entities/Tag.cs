using CourseStore.Common.Domain.Entitties;

namespace CourseStore.Core.Domain.Tags.Entities
{
    public class Tag : AggregateRoot<int>
    {
        public Tag(string tagName)
        {
            TagName = tagName;
            CourseTags = new List<CourseTag>();
            //CourseTags.AddRange(courseIds.Select(courseId => new CourseTag(courseId)));
        }

        public string TagName { get; private set; }

        public List<CourseTag> CourseTags { get; private set; }

        public void AddCourseTag(int courseId)
        {
            CourseTags.Add(new CourseTag(courseId));
        }
    }
}
