using Microsoft.EntityFrameworkCore.Storage;
using ProductStock.EntityConfiguration;

namespace ProductStock.UnitOfWork
{
    public class UnitofWork : IDisposable, IUnitofWork
    {
        private readonly ProductStockContext _context;
        private bool _disposed;
        private IDbContextTransaction _objTran;
        public UnitofWork(ProductStockContext context)
        {
            _context = context;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _objTran = _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _objTran.Commit();
        }
        public void RollBackTransaction()
        {
            _objTran.Rollback();
        }
    }
}
