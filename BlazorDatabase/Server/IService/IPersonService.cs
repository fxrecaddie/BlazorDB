using BlazorDatabase.Shared;
namespace BlazorDatabase.Server.IService
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPeople();
        Task<bool> CreatePerson(Person person);
        Task<bool> EditPerson(int id, Person person);
        Task<Person> SinglePerson(int id);
        Task<bool> DeletePerson(int id);
    }
}
