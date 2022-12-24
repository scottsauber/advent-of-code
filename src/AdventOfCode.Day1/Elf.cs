namespace AdventOfCode.Day1;

public class Elf
{
    public int Number { get; set; }
    public List<int> CaloriesBeingCarried { get; set; } = new();
    public int TotalCalories => CaloriesBeingCarried.Sum();
}