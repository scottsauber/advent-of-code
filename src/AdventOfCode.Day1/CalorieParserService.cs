namespace AdventOfCode.Day1;

public class CalorieParserService
{
    public int FindElfWithMostCalories(string elvesCarryingCalories)
    {
        var elves = elvesCarryingCalories
            .Split(Environment.NewLine + Environment.NewLine)
            .Select(x => new 
            {
                TotalCaloriesBeingCarried = x.Split(Environment.NewLine)
                    .Select(c => int.Parse(c))
                    .ToList()
                    .Sum()
            });
        return elves
            .MaxBy(x => x.TotalCaloriesBeingCarried)!
            .TotalCaloriesBeingCarried;
    }
}