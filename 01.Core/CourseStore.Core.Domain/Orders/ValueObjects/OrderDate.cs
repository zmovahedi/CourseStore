using CourseStore.Common.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Orders.ValueObjects
{
    public class OrderDate : ValueObject<OrderDate>
    {
        public DateTime Date { get; private set; }

        public OrderDate(DateTime date)
        {
            if (date > DateTime.Now)
                throw new ArgumentException("Order date cannot be greater then today.");

            this.Date = date;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Date;
        }
    }
}
