using static TestBackEnd.Models.PersonModel;

namespace TestBackEnd.Models.PersonViewModels
{
    public class PersonViewModel
    {
        public List<Person> Persons { get; set; }
        public List<Person> FilteredPersons { get; set; }
    }
}
