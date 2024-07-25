using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new List<int>();
        

        // Act

        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 13, 4, 9, 5, 28 };
        string expected = $"Odd numbers: 13, 9, 5{Environment.NewLine}Even numbers: 4, 28";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 12, 4, 8, 28 };
        string expected = $"Even numbers: 12, 4, 8, 28";
        

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 7, 9, 21, 33 };
        string expected = $"Odd numbers: 7, 9, 21, 33";


        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { -7, -18, -21, -33 };
        string expected = $"Odd numbers: -7, -21, -33{Environment.NewLine}Even numbers: -18";


        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
