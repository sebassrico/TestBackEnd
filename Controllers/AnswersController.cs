using Microsoft.AspNetCore.Mvc;
using TestBackEnd.Models;

public class AnswersController : Controller
{
	public IActionResult Index()
	{
		FooBarModel fooBarModel = new FooBarModel();
		int randomNumber = new Random().Next(1, 1001);
		string fooBarResult = fooBarModel.FooBar(randomNumber);

		VowelCountModel countVowelsModel = new VowelCountModel();
		string wordForCountVowels = "Superman";
		int vowelCountResult = countVowelsModel.CountVowels(wordForCountVowels);

		PersonModel personModel = new PersonModel();
		var personsList = personModel.GetPersons();
		var filteredPersons = personModel.GetPersonsAboveAge(personsList, 18);

		// Agregar nuevos ViewBag
		ViewBag.FooBarResult = fooBarResult;
		ViewBag.NumForFooBar = randomNumber;
		ViewBag.CountVowelsResult = vowelCountResult;
		ViewBag.WordForCountVowels = wordForCountVowels;

		ViewBag.Persons = personsList;

		return View("Index");
	}

}
