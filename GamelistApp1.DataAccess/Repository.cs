using GamelistApp1.Domain.Interfaces;

namespace GamelistApp1.DataAccess;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
{
    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public TEntity Create(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}