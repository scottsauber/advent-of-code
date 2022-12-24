using FluentAssertions;

namespace AdventOfCode.Day1.Tests;

public class CalorieParserServiceTests
{
    private readonly CalorieParserService _calorieParserService;

    public CalorieParserServiceTests()
    {
        _calorieParserService = new CalorieParserService();
    }

    [Fact]
    public void FindElfWithMostCalories_ShouldReturnNumberOfElfWithTheMostCalories()
    {
        var elvesCarryingCalories = @"1000
                                      2000
                                      3000

                                      4000

                                      5000
                                      6000

                                      7000
                                      8000
                                      9000

                                      10000";
        
        var elfNumber = _calorieParserService.FindElfWithMostCalories(elvesCarryingCalories);
        
        elfNumber.Should().Be(4);
    }
}