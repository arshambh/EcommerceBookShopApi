using Comman.Domain.Exceptions;
using Common.Domain;

namespace Domain.SellerAgg
{
    public class SellerInventory : BaseEntity
    {
        public SellerInventory(long productId, int count, int price)
        {
            if (price < 1 || count < 0)
                throw new InvalidDomainDataException();

            ProductId = productId;
            Count = count;
            Price = price;
        }

        public long SellerId { get; internal set; }
        public long ProductId { get; private set; }
        public int Count { get; private set; }
        public int Price { get; private set; }
    }
}