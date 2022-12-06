// See https://aka.ms/new-console-template for more information

using Day5;

var input = File.ReadAllLines("input/input.txt").ToList();

var crane = new Crane();
crane.InitializeInstructions(input);

var wareHouse = new WareHouse(input, crane);
wareHouse.InitializeCrates();
wareHouse.PerformLogisticsForTheElves();
var topShelfCrates = wareHouse.GetTopShelfCrates();
Console.WriteLine($"Top shelf crates spell={topShelfCrates}");