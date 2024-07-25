using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] numbers = new[] { 32 };
        // Act
        string result = Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("32"));
        //Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] numbers = new[] { 12, 20, -30 };
        // Act
        string result = Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("-30 20 12"));
    }
}
