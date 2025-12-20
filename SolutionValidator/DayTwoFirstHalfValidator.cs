using DayTwoFirstHalf;
using FluentAssertions;

namespace SolutionValidator;

public class DayTwoFirstHalfValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayTwoFirstHalfSolver_Default_Scenario()
    {
        //arrange
        var ids = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224, 1698522-1698528,446443-446449,38593856-38593862,565653-565659, 824824821-824824827,2121212118-2121212124";

        //act
        var solution = DayTwoFirstHalfSolver.SolveGiftShop(ids);

        //assert
        solution.Should().Be("1227775554");
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayTwoFirstHalfSolver()
    {
        //arrange
        var ids = await File.ReadAllTextAsync("Inputs/DayTwo/Input.txt");

        //act
        var solution = DayTwoFirstHalfSolver.SolveGiftShop(ids);

        //assert
        solution.Should().Be("");
    }
}
