using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 15 };
        int expected =  15;

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int>() { 15, 20, 60, 23, 31};
        int expected = 60;

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int>() { -55, -20, -60, -23, -31 };
        int expected = -20;

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int>() { 15, -20, -60, 23, -31 };
        int expected = 23;

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int>() { 1, 3, 15, 15, 10, 13 };
        int expected = 15;

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
