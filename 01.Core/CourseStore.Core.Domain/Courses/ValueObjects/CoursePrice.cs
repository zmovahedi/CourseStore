using CourseStore.Common.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Courses.ValueObjects
{
    public class CoursePrice : ValueObject<CoursePrice>
    {
        public CoursePrice(int price)
        {
            if (price < 100)
                throw new ArgumentOutOfRangeException("The order price can not be less than 100 Rials");

            Price = price;
        }

        public int Price { get; private set; }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }
    }
}
