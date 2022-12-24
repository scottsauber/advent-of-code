namespace AdventOfCode.Day1;

public class CalorieParserService
{
    public int FindElfWithMostCalories(string elvesCarryingCalories)
    {
        return elvesCarryingCalories.Split(Environment.NewLine + Environment.NewLine)
            .Select((x, i) => new Elf
            {
                Number = i + 1,
                CaloriesBeingCarried = x.Split(Environment.NewLine).Select(x => int.Parse(x)).ToList()
            })
            .MaxBy(x => x.CaloriesBeingCarried.Sum())
            .Number;
    }
}