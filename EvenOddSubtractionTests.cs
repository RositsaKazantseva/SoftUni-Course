﻿using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNums = new[] {2, 4, 6};
        // Act
        int result = EvenOddSubtraction.FindDifference(evenNums) ;
        
        

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddNums = new[] { 3, 5, 7 };
        // Act
        int result = EvenOddSubtraction.FindDifference(oddNums);

        // Assert
        Assert.That(result, Is.EqualTo(- 15));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] oddNums = new[] { -4 , 5, 8 };
        // Act
        int result = EvenOddSubtraction.FindDifference(oddNums);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}
