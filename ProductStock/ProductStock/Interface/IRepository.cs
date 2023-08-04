namespace ProductStock.Interface
{
    public interface IRepository<TE, TK> where TE : class
    {
        void Add(TE entity);
        void Update(TE entity);
        void Delete(TE entity);
        IQueryable<TE> GetQueryable();
        IEnumerable<TE> GetAll();
        Task<IEnumerable<TE?>> GetAllAsync();
        TE? GetById(string id);
        Task<TE?> GetByIdAsync(string id);
        Task AddAsync(TE entity);
        Task UpdateAsync(TE entity);
        Task DeleteAsync(TE entity);

    }
}