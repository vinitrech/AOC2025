using DayThreeSecondHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayThreeSecondHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayThreeSecondHalfSolver_Default_Scenario()
    {
        //arrange
        var banks = new string[] { "987654321111111", "811111111111119", "234234234234278", "818181911112111" };

        //act 
        var largestJoltage = DayThreeSecondHalfSolver.SolveLobby(banks);

        //assert
        largestJoltage.Should().Be(3121910778619L);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayThreeSecondHalfSolver()
    {
        //arrange
        var banks = await File.ReadAllLinesAsync("Inputs/DayThree/Input.txt");

        //act
        var largestJoltage = DayThreeSecondHalfSolver.SolveLobby(banks);

        //assert
        largestJoltage.Should().Be(171846613143331L);
    }
}
