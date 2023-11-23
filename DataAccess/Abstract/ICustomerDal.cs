using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public partial interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
