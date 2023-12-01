namespace TestBackEnd.Models
{
	public class FooBarModel
	{
		public string FooBar(int num)
		{
			string answer = "It is not a multiple of either 5 or 3";

			if (num < 1 || num > 1000)
			{
				answer = "You can't enter numbers between 1000 and 1";
			}
			else
			{
				if (num % 5 == 0)
				{
					if (num % 3 == 0)
					{
						answer = "foo bar";
					}
					else
					{
						answer = "foo";
					}
				}
				else
				{
					if (num % 3 == 0)
					{
						answer = "bar";
					}
				}
			}

			return answer;
		}
	}
}
