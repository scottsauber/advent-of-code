namespace AdventOfCode.Day1;

public class CalorieParserService
{
    public int FindElfWithMostCalories(string elvesCarryingCalories)
    {
        var elves = elvesCarryingCalories
            .Split(Environment.NewLine + Environment.NewLine);
        var caloriesByElf = elves
            .Select(x => new 
            {
                TotalCaloriesBeingCarried = x
                    .Split(Environment.NewLine)
                    .Select(c => int.Parse(c))
                    .ToList()
                    .Sum()
            });
        return caloriesByElf
            .MaxBy(x => x.TotalCaloriesBeingCarried)!
            .TotalCaloriesBeingCarried;
    }
}