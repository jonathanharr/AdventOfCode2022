namespace Day4;

public class Section
{
    public int LowerBoundary { get; set; }
    public int UpperBoundary { get; set; }

    public Section(int lowerBoundary, int upperBoundary)
    {
        LowerBoundary = lowerBoundary;
        UpperBoundary = upperBoundary;
    }

    public bool ContainsSectionIdWithinRange(int sectionId)
    {
        return sectionId >= LowerBoundary && sectionId <= UpperBoundary;
    }
}