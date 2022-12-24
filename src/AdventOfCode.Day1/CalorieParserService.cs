namespace AdventOfCode.Day1;

public class CalorieParserService
{
    public int FindElfWithMostCalories(string elvesCarryingCalories)
    {
        var elves = elvesCarryingCalories
            .Split(Environment.NewLine + Environment.NewLine)
            .Select((x, i) => new Elf
            {
                Number = i + 1,
                CaloriesBeingCarried = x.Split(Environment.NewLine).Select(c => int.Parse(c)).ToList()
            });
        return elves
            .MaxBy(x => x.TotalCalories)!
            .TotalCalories;
    }
}