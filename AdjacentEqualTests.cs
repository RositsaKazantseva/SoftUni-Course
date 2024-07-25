using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result,Is.EqualTo(""));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";
        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 2, 4, 4, 5, 5, 5};
        string exected = "1 4 8 15";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> list = new List<int> { 5, 5, 5, 5 };
        string exected = "20";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> list = new List<int> { 1, 1, 3, 4, 5 };
        string exected = "2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 5 };
        string exected = "1 2 3 4 15";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> list = new List<int> { 1, 2, 3, 3, 3, 4, 5 };
        string exected = "1 2 9 4 5";

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }
}
