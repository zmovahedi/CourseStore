using CourseStore.Common.Domain.ValueObjects;

namespace CourseStore.Core.Domain.Orders.ValueObjects
{
    public class OrderPrice : ValueObject<OrderPrice>
    {
        public OrderPrice(int price)
        {
            if (price < 30000)
                throw new ArgumentOutOfRangeException("The order price can not be less than 30000 Rials");

            Price = price;
        }

        public int Price { get; private set; }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Price;
        }
    }
}
