using CourseStore.Common.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Teachers.ValueObjects
{
    public class FullName : ValueObject<FullName>
    {
        public FullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("FirstName cannot be empty.");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("LastName cannot be empty.");

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
