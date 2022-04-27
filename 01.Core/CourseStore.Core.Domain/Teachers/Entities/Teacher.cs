using CourseStore.Common.Domain.Entitties;
using CourseStore.Core.Domain.Teachers.ValueObjects;

namespace CourseStore.Core.Domain.Teachers.Entities
{
    public class Teacher : AggregateRoot<int>
    {
        public Teacher(FullName fullName)
        {
            FullName = fullName;
        }

        protected Teacher()
        { }

        public FullName FullName { get; private set; }
    }
}
