using CourseStore.Common.Domain.Entitties;
using CourseStore.Core.Domain.Orders.ValueObjects;
using CourseStore.Core.Domain.Shared.ValueObjects;

namespace CourseStore.Core.Domain.Orders.Entities
{
    public class Order : AggregateRoot<int>
    {
        public Order(OrderDate orderDate, Email customerEmail, OrderPrice price, int courseId)
        {
            OrderDate = orderDate;
            CustomerEmail = customerEmail;
            Price = price;
            CourseId = courseId;
        }

        protected Order()
        { }

        public OrderDate OrderDate { get; private set; }
        public Email CustomerEmail { get; private set; }
        public OrderPrice Price { get; private set; }
        public int CourseId { get; private set; }
    }
}
