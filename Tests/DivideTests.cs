namespace Tests
{
	[TestFixture]
	public class DivideTests
	{
		MathCalc mathCalculations = new MathCalc();

		[TestCase(6, 2, 3)]
		[TestCase(-10, 5, -2)]
		[TestCase(0, 100, 0)]
		[TestCase(123, 3, 41)]
		public void Divide_ValidInputs_ReturnsCorrectResult(int dividend, int divisor, int expectedResult)
		{
			// Arrange & Act
			int actualResult = mathCalculations.Divide(dividend, divisor);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Divide_DivideByZero_ThrowsException()
		{
			// Arrange
			int dividend = 10;
			int divisor = 0;

			// Act & Assert
			Assert.Throws<System.DivideByZeroException>(() => mathCalculations.Divide(dividend, divisor));
		}
	}
}