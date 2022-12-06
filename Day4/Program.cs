// See https://aka.ms/new-console-template for more information

using Day4;

Section SplitIntoSection(string sectionsForElf)
{
    var sectionSpan = sectionsForElf.Split('-');
    var sectionStart = sectionSpan[0];
    var sectionEnd = sectionSpan[1];

    return new Section(Convert.ToInt32(sectionStart), Convert.ToInt32(sectionEnd));
}

var sections = File.ReadAllLines("input/input.txt").ToList();

var elvenPairs = (from row in sections select row.Split(',') 
    into split let sectionA = SplitIntoSection(split[0]) 
    let sectionB = SplitIntoSection(split[1]) 
    select new ElvenPairs(sectionA, sectionB)).ToList();
    

var amountOfPairsSpanningEachOthersRange = 
    elvenPairs.Count(elvenPair => elvenPair.IsContainedByOneOrTheOther());

Console.WriteLine($"Amount of pairs where one contains the others range {amountOfPairsSpanningEachOthersRange}");

var amountOfPairsThatOverLapAtAll = elvenPairs.Count(elvenPair => elvenPair.OverLapsOneOrTheOther());

Console.WriteLine($"Amount of pairs where they overlap {amountOfPairsThatOverLapAtAll}");

