namespace Tests
{
	[TestFixture]
	public class MultiplyTest
	{
		MathCalc mathCalculations = new MathCalc();

		[TestCase(2, 3, 6)]
		[TestCase(-4, 5, -20)]
		[TestCase(0, 100, 0)]
		[TestCase(10, 0, 0)]
		[TestCase(123, 456, 56088)]
		public void Multiply_ValidInputs_ReturnsCorrectResult(int number1, int number2, int expectedProduct)
		{
			// Arrange & Act
			int actualProduct = mathCalculations.Multiply(number1, number2);

			// Assert
			Assert.AreEqual(expectedProduct, actualProduct);
		}
	}
}