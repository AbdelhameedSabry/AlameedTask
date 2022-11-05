

namespace CRM_Application.DAL;

public interface IGenericRepo<T>
{
    List<T> GetAll();

    T GetById(int id);

    void Add(T entity); 

    void Update(T entity);

    void Delete(T entity);

}
