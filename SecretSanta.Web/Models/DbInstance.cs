using System.Collections.Generic;

namespace SecretSanta.Web.Models
{
    public class DatabaseInstance : IDatabaseInstance
    {
        private readonly IList<Person> _people;

        public DatabaseInstance()
        {
            _people = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            _people.Add(p);
        }

        public IList<Person> GetAll()
        {
            return _people;
        }
    }

    public interface IDatabaseInstance
    {
        void AddPerson(Person p);

        IList<Person> GetAll();
    }
}
