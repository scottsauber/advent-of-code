namespace AdventOfCode.Day1;

public class CalorieParserService
{
    public int FindMaxCaloriesWithMostCalories(string elvesCarryingCalories)
    {
        var elves = elvesCarryingCalories
            .Split(Environment.NewLine + Environment.NewLine);
        var caloriesByElf = elves
            .Select(x => x
                    .Split(Environment.NewLine)
                    .Select(c => int.Parse(c))
                    .ToList()
                    .Sum());
        return caloriesByElf
            .OrderByDescending(x => x)!
            .Take(3)
            .Sum();

    }
}