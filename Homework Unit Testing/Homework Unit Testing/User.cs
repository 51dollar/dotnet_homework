namespace User_Greeting
{
	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public User(string name, int age)
		{
			if (age < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			Name = name;
			Age = age;
		}

		public string GetGreeting()
		{
			if (Age >= 18)
			{
				return $"Привет, {Name}! Добро пожаловать!";
			}
			else
			{
				return $"Привет, {Name}! Ты слишком молод, чтобы войти.";
			}
		}
	}
}
