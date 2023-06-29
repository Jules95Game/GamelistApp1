namespace GamelistApp1.Domain.Interfaces;

public interface IService<TEntity> where TEntity : IEntity
{
    public List<TEntity> GetAll();

    public List<TEntity> GetTop100();

    public List<TEntity> SearchByQuery(string query);

    public TEntity GetById(int id);

    public TEntity Create(TEntity entity);

    public TEntity Update(TEntity entity);

    public void Delete(int id);
}