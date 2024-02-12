namespace Tests
{
	[TestFixture]
	public class SumTest
	{
		MathCalc mathCalculations = new MathCalc();

		[TestCase(5, 7, 12)]
		[TestCase(-10, 20, 10)]
		[TestCase(-8, -4, -12)]
		[TestCase(0, 0, 0)]
		[TestCase(100, -50, 50)]
		[TestCase(123456789, 987654321, 1111111110)]
		public void Sum_ValidInputs_ReturnsCorrectResult(int number1, int number2, int expectedSum)
		{
			// Arrange & Act
			int actualSum = mathCalculations.Sum(number1, number2);

			// Assert
			Assert.AreEqual(expectedSum, actualSum);
		}
	}
}