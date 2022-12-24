using AdventOfCode.Day1;

var file = File.ReadAllText("Input.txt");
var calorieParserService = new CalorieParserService();
var calorieCount = calorieParserService.FindMaxCaloriesWithMostCalories(file);

Console.WriteLine(calorieCount);