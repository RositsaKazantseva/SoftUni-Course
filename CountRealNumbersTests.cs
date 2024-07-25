using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 33 };

        string expected = "33 -> 1";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        

        int[] input = new int[] { 55, 2, 9, 28, 9, 55, 9 };
        string expected = $"2 -> 1{Environment.NewLine}9 -> 3{Environment.NewLine}28 -> 1{Environment.NewLine}55 -> 2";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] input = new int[] { -3, - 5, -23 , -2 , -5};
        string expected = $"-23 -> 1{Environment.NewLine}-5 -> 2{Environment.NewLine}-3 -> 1{Environment.NewLine}-2 -> 1";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] input = new int[] { 0, 0, 0, 0, };
        string expected = $"0 -> 4";

        string result = CountRealNumbers.Count(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
