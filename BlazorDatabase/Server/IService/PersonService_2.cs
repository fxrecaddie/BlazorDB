using BlazorDatabase.Shared;

namespace BlazorDatabase.Server.IService
{
    //For implement database
    public class PersonService_2
    {
        private List<Person> _person;

        public PersonService_2()
        {
            _person = new List<Person>();
        }

        public List<Person> GetPerson()
        {
            return _person;
        }
        public void AddPerson(Person person)
        {
            _person.Add(person);
        }

        public void DeletePerson(string personID)
        {
            _person.RemoveAll(a => a.Id == personID);
        }


    }
}
