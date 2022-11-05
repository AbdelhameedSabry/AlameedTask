

namespace CRM_Application.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly CRMDbContext _context;

    public GenericRepo(CRMDbContext context)
    {
        _context = context;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);  
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }
   
}
