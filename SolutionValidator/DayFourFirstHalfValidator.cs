using DayFourFirstHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayFourFirstHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFourFirstHalfSolver_Default_Scenario()
    {
        //arrange
        var rolls = new string[] { "..@@.@@@@.", "@@@.@.@.@@", "@@@@@.@.@@", "@.@@@@..@.", "@@.@@@@.@@", ".@@@@@@@.@", ".@.@.@.@@@", "@.@@@.@@@@", ".@@@@@@@@.", "@.@.@@@.@." };

        //act 
        var rollsNumber = DayFourFirstHalfSolver.SolvePrintingDepartment(rolls);

        //assert
        rollsNumber.Should().Be(13);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayFourFirstHalfSolver()
    {
        //arrange
        var rolls = await File.ReadAllLinesAsync("Inputs/DayFour/Input.txt");

        //act
        var rollsNumber = DayFourFirstHalfSolver.SolvePrintingDepartment(rolls);

        //assert
        rollsNumber.Should().Be(1320L);
    }
}
