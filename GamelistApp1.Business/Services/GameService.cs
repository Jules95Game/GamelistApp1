using GamelistApp1.Domain.Interfaces;
using GamelistApp1.Domain.Models;

namespace GamelistApp1.Business.Services;

public class GameService : IService<Game>
{
    private readonly IRepository<Game> _repository;

    public GameService(IRepository<Game> repository) => _repository = repository;

    public List<Game> GetAll() => _repository.GetAll().ToList();

    public List<Game> GetTop100() => _repository.GetAll().Take(100).ToList();

    public List<Game> SearchByQuery(string query) => _repository.GetAll()
        .Where(x => x.Title.ToLower().Contains(query.ToLower())
        || (x.Description != null && x.Description.ToLower().Contains(query.ToLower()))
        || x.Publisher.ToLower().Contains(query.ToLower()))
        .ToList();

    public Game? GetById(int id) => _repository.GetById(id).SingleOrDefault();

    public Game? Create(Game entity) => _repository.GetAll()
        .Where(x => x.Title == entity.Title && x.Platform == entity.Platform)
        .SingleOrDefault() != null
            ? _repository.Create(entity)
            : null;

    public Game? Update(Game entity) => _repository.GetAll()
        .Where(x => x.Title == entity.Title && x.Platform == entity.Platform)
        .SingleOrDefault() == null
            ? _repository.Update(entity)
            : null;

    public void Delete(int id) => _repository.Delete(id);
}