namespace ProductStock.Repository
{
    public interface IRepository<TE, TK> where TE : class
    {
        void Add(TE entity);
        void Update(TE entity); 
        void Delete(TE entity);
        IQueryable<TE> GetQueryable();
        Task<IEnumerable<TE?>> GetAllAsync();
        TE? GetById(string id);
        Task<TE?> GetByIdAsync(string id);
        Task AddAsync(TE entity);
        Task<TE> UpdateAsync(TE entity);
        Task<TE> DeleteAsync(TE entity);

    }
}