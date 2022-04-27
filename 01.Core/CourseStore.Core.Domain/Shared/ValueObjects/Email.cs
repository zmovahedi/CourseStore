using CourseStore.Common.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Shared.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty.");
            
            Value = value;
        }

        public string Value { get; private set; }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}
