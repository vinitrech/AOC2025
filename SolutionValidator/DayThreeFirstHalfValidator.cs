using DayThreeFirstHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayThreeFirstHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayThreeFirstHalfSolver_Default_Scenario()
    {
        //arrange
        var banks = new string[] { "987654321111111", "811111111111119", "234234234234278", "818181911112111" };

        //act 
        var largestJoltage = DayThreeFirstHalfSolver.SolveLobby(banks);

        //assert
        largestJoltage.Should().Be(357);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayThreeFirstHalfSolver()
    {
        //arrange
        var banks = await File.ReadAllLinesAsync("Inputs/DayThree/Input.txt");

        //act
        var largestJoltage = DayThreeFirstHalfSolver.SolveLobby(banks);

        //assert
        largestJoltage.Should().Be(0);
    }
}
