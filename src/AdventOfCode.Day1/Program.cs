using AdventOfCode.Day1;

var file = File.ReadAllText("Input.txt");
var calorieParserService = new CalorieParserService();
var elfNumber = calorieParserService.FindElfWithMostCalories(file);

Console.WriteLine(elfNumber);