using User_Greeting;

namespace UserTests
{
	public class GetGreetingTests
	{
		[Fact]
		public void GetGreeting_ReturnsCorrectGreetingForAdult()
		{
			User user = new User("Dima", 22);

			string greeting = user.GetGreeting();

			Assert.Equal("������, Dima! ����� ����������!", greeting);
		}

		[Fact]
		public void GetGreeting_ReturnsCorrectGreetingForYoungUser()
		{
			User user = new User("Alina", 17);

			string greeting = user.GetGreeting();

			Assert.Equal("������, Alina! �� ������� �����, ����� �����.", greeting);
		}

		[Fact]
		public void Constructor_DoesNotAllowNegativeAge()
		{

			Assert.Throws<System.ArgumentOutOfRangeException>(() => new User("Bob", -5));
		}
	}
}