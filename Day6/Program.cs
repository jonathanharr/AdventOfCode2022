// See https://aka.ms/new-console-template for more information

string GetNewSequence(ref string sequence, char currentChar)
{
    return sequence.Contains(currentChar) ? sequence.Split(currentChar)[1] + currentChar : sequence + currentChar;
}

int SequenceMarker(string input, int sequenceMaxCount)
{
    var i = 1;
    for (var sequence = ""; (sequence = GetNewSequence(ref sequence, input[i - 1])).Distinct().Count() != sequenceMaxCount;)
    {
        i++;
    }
    
    return i;
}


var packet = File.ReadAllText("input/input.txt");
var startOfPacketMarker = SequenceMarker(packet, 4);
Console.WriteLine($"Start of packet marker={startOfPacketMarker}");

var startOfMessageMarker = SequenceMarker(packet, 14);
Console.WriteLine($"Start of message marker={startOfMessageMarker}");
