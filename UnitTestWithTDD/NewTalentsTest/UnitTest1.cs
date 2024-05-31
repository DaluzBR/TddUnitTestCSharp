using NewTalents.Models;

namespace NewTalentsTest;

public class UnitTest1
{
    private readonly Calculator _calc = new();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 5, 8)]
    [InlineData(12, 26, 38)]
    [InlineData(100, 200, 300)]
    [InlineData(7, 8, 15)]
    public void WhenSum_GivenTwoNumbersInteger_ThenReturnResult(int value1, int value2, int result)
    {
        // Arrange
        var number1 = value1;
        var number2 = value2;
        var expected = result;

        // Act
        var actual = _calc.Sum(number1, number2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 5, 3)]
    [InlineData(25, 17, 8)]
    [InlineData(64, 26, 38)]
    [InlineData(500, 200, 300)]
    [InlineData(23, 8, 15)]
    public void WhenSubtract_GivenTwoNumbersInteger_ThenReturnResult(int value1, int value2, int result)
    {
        // Arrange
        var number1 = value1;
        var number2 = value2;
        var expected = result;

        // Act
        var actual = _calc.Subtract(number1, number2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 5, 40)]
    [InlineData(25, 17, 425)]
    [InlineData(64, 26, 1664)]
    [InlineData(500, 200, 100000)]
    [InlineData(23, 8, 184)]
    public void WhenMultiply_GivenTwoNumbersInteger_ThenReturnResult(int value1, int value2, int result)
    {
        // Arrange
        var number1 = value1;
        var number2 = value2;
        var expected = result;

        // Act
        var actual = _calc.Multiply(number1, number2);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(24, 8, 3)]
    [InlineData(81, 3, 27)]
    [InlineData(64, 32, 2)]
    [InlineData(600, 6, 100)]
    [InlineData(48, 8, 6)]
    public void WhenDivision_GivenTwoNumbersInteger_ThenReturnResult(int value1, int value2, int result)
    {
        // Arrange
        var number1 = value1;
        var number2 = value2;
        var expected = result;

        // Act
        var actual = _calc.Division(number1, number2);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void WhenDivision_GivenDenominatorZero_ThenReturnArithmeticException()
    {
        // Arrange (Não necessário)

        // Act
        void act() => _calc.Division(2, 0);

        // Assert
        ArithmeticException exception = Assert.Throws<ArithmeticException>(act);
        Assert.Equal("Erro: Divisão por zero.", exception.Message);
    }

    [Fact]
    public void WhenShowHistoric_GivenAmountOfItensGreaterThree_ThenReturnSizeListEqualThree()
    {
        // Arrange (Não necessário)
        _calc.Sum(2, 3);
        _calc.Subtract(8, 3);
        _calc.Multiply(2, 3);
        _calc.Division(10, 2);
        var expected = 3;

        // Act
        var actual = _calc.ShowHistoric().Count;

         // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WhenShowHistoric_GivenAmountOfItensEqualTwo_ThenReturnSizeListEqualTho()
    {
        // Arrange (Não necessário)
        _calc.Sum(2, 3);
        _calc.Subtract(8, 3);
        var expected = 2;

        // Act
        var actual = _calc.ShowHistoric().Count;

         // Assert
        Assert.Equal(expected, actual);
    }
}