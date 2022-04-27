using CourseStore.Common.Domain.Entitties;

namespace CourseStore.Core.Domain.Comments.Entities
{
    public class CourseComment : AggregateRoot<int>
    {
        public CourseComment(string commentBy, DateTime commentDate, string comment, int courseId)
        {
            CommentBy = commentBy;
            CommentDate = commentDate;
            Comment = comment;
            CourseId = courseId;
            IsValid = false;
        }

        public string CommentBy { get; private set; }
        public DateTime CommentDate { get; private set; }
        public bool IsValid { get; private set; }
        public string Comment { get; private set; }
        public int CourseId { get; private set; }
    }
}
