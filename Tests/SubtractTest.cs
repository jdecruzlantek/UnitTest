namespace Tests
{
	[TestFixture]
	public class SubtractTest
	{
		MathCalc mathCalculations = new MathCalc();

		[TestCase(10, 5, 5)]
		[TestCase(-10, -5, -5)]
		[TestCase(0, 0, 0)]
		[TestCase(100, -50, 150)]
		[TestCase(123456789, 987654321, -864197532)]
		public void Subtract_ValidInputs_ReturnsCorrectResult(int number1, int number2, int expectedDifference)
		{
			// Arrange & Act
			int actualDifference = mathCalculations.Subtract(number1, number2);

			// Assert
			Assert.AreEqual(expectedDifference, actualDifference);
		}
	}
}