namespace GamelistApp1.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : IEntity
{
    public IQueryable<TEntity> GetAll();

    public IQueryable<TEntity> GetById(int id);

    public TEntity Create(TEntity entity);

    public TEntity Update(TEntity entity);

    public void Delete(int id);
}