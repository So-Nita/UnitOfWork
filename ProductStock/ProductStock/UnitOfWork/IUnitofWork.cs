namespace ProductStock.UnitOfWork
{
    public interface IUnitofWork
    {
        void BeginTransaction();
        void CommitTransaction();
        void Dispose();
        void RollBackTransaction();
    }
}