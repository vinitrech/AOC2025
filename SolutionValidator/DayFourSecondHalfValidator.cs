using DayFourSecondHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayFourSecondHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFourSecondHalfSolver_Default_Scenario()
    {
        //arrange
        var rolls = new string[] { "..@@.@@@@.", "@@@.@.@.@@", "@@@@@.@.@@", "@.@@@@..@.", "@@.@@@@.@@", ".@@@@@@@.@", ".@.@.@.@@@", "@.@@@.@@@@", ".@@@@@@@@.", "@.@.@@@.@." };

        //act 
        var rollsNumber = DayFourSecondHalfSolver.SolvePrintingDepartment(rolls);

        //assert
        rollsNumber.Should().Be(43L);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFourSecondHalfSolver()
    {
        //arrange
        var rolls = await File.ReadAllLinesAsync("Inputs/DayFour/Input.txt");

        //act
        var rollsNumber = DayFourSecondHalfSolver.SolvePrintingDepartment(rolls);

        //assert
        rollsNumber.Should().Be(8354L);
    }
}
