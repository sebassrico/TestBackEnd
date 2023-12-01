using static TestBackEnd.Models.PersonModel;

namespace TestBackEnd.Models
{
	public class CombinedResultViewModel
	{
		public string FooBarResult { get; set; }
		public int CountVowelsResult { get; set; }
		public List<Person> Persons { get; set; }
	}
}
