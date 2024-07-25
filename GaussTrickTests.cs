using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new List<int> { 5 };
        List<int> expected = new List<int> { 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(expected);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountElements = new List<int> { 2, 4, 6, 8};
        List<int> expected = new List<int> { 10, 10 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountElements = new List<int> { 2, 4, 6, 8, 10 };
        List<int> expected = new List<int> { 12, 12, 6 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountElements = new List<int> { 2, 4, 6, 8 , 12, 14};
        List<int> expected = new List<int> { 16, 16, 14 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountElements = new List<int> { 2, 4, 6, 8, 10, 15, 20 };
        List<int> expected = new List<int> { 22, 19, 16, 8 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
