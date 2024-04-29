using SMP.Core.Models;

namespace SMP.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDataHelper<Category> _catHelper { get; }
        IDataHelper<Customer> _cusHelper { get; }
        IDataHelper<Purchase> _purHelper { get; }
        IDataHelper<SellOperation> _sellHelper { get; }
        IDataHelper<Supplier> _supHelper { get; }
        IDataHelper<SystemRecords> _systemHelper { get; }

        Task<int> CompleteAsync();
    }
}
