using Comman.Domain.Exceptions;
using Common.Domain;
using Domain.UserAgg.Enums;

namespace Domain.UserAgg
{
    public class Wallet : BaseEntity
    {
        public Wallet(int price, string desciption, bool isFinally, DateTime? finallyDate, WalletType type)
        {
            if (price < 500)
                throw new InvalidDomainDataException();

            Price = price;
            Desciption = desciption;
            IsFinally = isFinally;
            FinallyDate = finallyDate;
            Type = type;
        }

        public long UserId { get; internal set; }
        public int Price { get; private set; }
        public string Desciption { get; private set; }
        public bool IsFinally { get; private set; }
        public DateTime? FinallyDate { get; private set; }
        public WalletType Type { get; private set; }

        public void Finally(string refCode)
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
            Desciption += $" کد پیگیری : {refCode}";
        }

        public void Finally()
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
        }
    }
}
