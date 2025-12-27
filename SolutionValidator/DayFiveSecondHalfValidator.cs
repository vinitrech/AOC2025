using DayFiveSecondHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayFiveSecondHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFiveSecondHalfSolver_Default_Scenario()
    {
        //arrange
        var input = new string[] { "3-5", "10-14", "16-20", "12-18", "", "1", "5", "8", "11", "17", "32" };

        //act 
        var result = DayFiveSecondHalfSolver.SolveCafeteria(input);

        //assert
        result.Should().Be(3);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFiveSecondHalfSolver()
    {
        //arrange
        var input = await File.ReadAllLinesAsync("Inputs/DayFive/Input.txt");

        //act
        var result = DayFiveSecondHalfSolver.SolveCafeteria(input);

        //assert
        result.Should().Be(707);
    }
}
