using Common.Domain;
using Domain.RoleAgg.Enums;

namespace Domain.RoleAgg
{
    public class RolePermission:BaseEntity
    {
        public long RoleId { get; set; }
        public Permission Permission { get; set; }
    }
}
