using GamelistApp1.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamelistApp1.DataAccess;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly DataContext _dataContext;
    private readonly DbSet<TEntity> _table;

    public Repository(DataContext dataContext)
    {
        _dataContext = dataContext;
        _table = _dataContext.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll() => _table;

    public IQueryable<TEntity> GetById(int id) => _table.Where(x => x.Id == id);

    public TEntity Create(TEntity entity)
    {
        _table.Add(entity);
        Save();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        _table.Update(entity);
        Save();
        return entity;
    }

    public void Delete(int id)
    {
        TEntity? entity = _table.Find(id);
        if (entity != null)
        {
            _table.Remove(entity);
            Save();
        }
    }

    private void Save() => _dataContext.SaveChanges();
}