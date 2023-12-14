using unit_testing;

namespace xUnit_tests
{
    public class CatTests
    {
        [Fact]
        public void Moew_must_output_At_Least_One_Line_to_console()
        {
            // arrange
            var outputWriter = new StringWriter();
            Console.SetOut(outputWriter);
            var cat = new Cat();

            // act
            cat.Voice();

            // assert
            var outputString = outputWriter.ToString();
            var firstNewLineCharacterIndex = outputString.IndexOf('\n');

            if (firstNewLineCharacterIndex < 0)
            {
                Assert.Fail("Не найдено строчки в Voice() в классе Cat.");
            }
        }
    }
}