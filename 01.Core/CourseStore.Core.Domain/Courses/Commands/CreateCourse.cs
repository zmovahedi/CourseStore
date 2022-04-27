namespace CourseStore.Core.Domain.Courses.Commands
{
    public class CreateCourse
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int Price { get; set; }
    }
}
