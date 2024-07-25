using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 23 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(23));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = new[] { 2, 5, 7 };

        // Act
        double result = Average.CalculateAverage(numbers);
       

        // Assert
        Assert.That(result, Is.EqualTo(4.666666666666667d));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = new[] { -2, -5, -7 };

        // Act
        double result = Average.CalculateAverage(numbers);
        
        // Assert
        Assert.That(result, Is.EqualTo(-4.666666666666667d));
    }


    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = new[] { -2, 5, -3 };

        // Act
        double result = Average.CalculateAverage(numbers);
        

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}


