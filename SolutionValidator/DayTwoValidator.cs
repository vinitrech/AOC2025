using DayTwo;
using FluentAssertions;

namespace SolutionValidator;

public class DayTwoValidator
{
    [Fact]
    public static async Task On_Sucess_Should_Validate_DayTwoSolver_Default_Scenario()
    {
        //arrange
        var ids = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224, 1698522-1698528,446443-446449,38593856-38593862,565653-565659, 824824821-824824827,2121212118-2121212124";

        //act
        var solution = DayTwoSolver.SolveGiftShop(ids);

        //assert
        solution.Should().Be(4174379265L);
    }

    [Fact]
    public static async Task On_Sucess_Should_Validate_DayTwoSolver()
    {
        //arrange
        var ids = await File.ReadAllTextAsync("Inputs/DayTwo/Input.txt");

        //act
        var solution = DayTwoSolver.SolveGiftShop(ids);

        //assert
        solution.Should().Be(26202168557L);
    }
}
