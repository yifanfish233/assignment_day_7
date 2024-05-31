namespace Assignment4;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _context;

    public GenericRepository()
    {
        _context = new List<T>();
    }

    public void Add(T item)
    {
        _context.Add(item);
    }

    public void Remove(T item)
    {
        _context.Remove(item);
    }

    public void Save()
    {
       
    }

    public IEnumerable<T> GetAll()
    {
        return _context;
    }

    public T GetById(int id)
    {
        return _context.FirstOrDefault(x => x.Id == id);
    }
}