// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


var priorities = new List<char>
{
    '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
};
Console.WriteLine(priorities.Count);

var rugSackInventory = File.ReadAllLines("input/input.txt").ToList();

Console.WriteLine(rugSackInventory.Count);

var listOfContainedPriorities = new List<char>();

foreach (var rugsack in rugSackInventory)
{
    var firstCompartment = rugsack.Substring(0, rugsack.Length / 2);
    var lastCompartment = rugsack.Substring(rugsack.Length / 2, rugsack.Length / 2);

    var isFinished = false;
    foreach (var itemType in firstCompartment.TakeWhile(itemType => !isFinished))
    {
        if (lastCompartment.Any(itemTypeInOtherCompartment => itemType == itemTypeInOtherCompartment))
        {
            listOfContainedPriorities.Add(itemType);
            isFinished = true;
        }
    }
}

Console.WriteLine($"List of contained priorities: {listOfContainedPriorities.Count}");

var priorityScore = 0;
var priorityString = "";
foreach (var containedPrioty in listOfContainedPriorities)
{
    priorityString += containedPrioty;
    priorityScore += priorities.IndexOf(containedPrioty);
}
Console.WriteLine(priorityString);
Console.WriteLine(priorityScore);

var threeRugSacks = new List<string>();
var listOfThrees = new List<List<string>>();
foreach (var rugSack in rugSackInventory)
{
    threeRugSacks.Add(rugSack);
    if (threeRugSacks.Count == 3)
    {
        listOfThrees.Add(threeRugSacks);
        threeRugSacks = new List<string>();
    }
}

var badges = new List<char>();

Console.WriteLine($"List of thees = {listOfThrees.Count}");

foreach (var theeRugSack in listOfThrees)
{
    var rugSackOne = theeRugSack[0];
    var rugSackB = theeRugSack[1];
    var rugSackC = theeRugSack[2];
    var isFound = false;

    foreach (var itemType in rugSackOne.TakeWhile(itemType => !isFound))
    {
        foreach (var itemTypeB in rugSackB.TakeWhile(itemTypeB => !isFound).Where(itemTypeB => itemType == itemTypeB))
        {
            if (rugSackC.Any(itemTypeC => itemTypeC == itemType))
            {
                isFound = true;
                badges.Add(itemType);
            }
        }
    }
}

Console.WriteLine($"BADGES COUNT = {badges.Count}");

var badgesScore = 0;
var badgesString = "";
foreach (var containedPrioty in badges)
{
    badgesString += containedPrioty;
    badgesScore += priorities.IndexOf(containedPrioty);
}

Console.WriteLine($"Badges Score={badgesScore}");