namespace Day4;

public class ElvenPairs
{
    public Section ElvenSectionFirst { get; set; }
    public Section ElvenSectionSecond { get; set; }

    public ElvenPairs(Section elvenSectionFirst, Section elvenSectionSecond)
    {
        ElvenSectionFirst = elvenSectionFirst;
        ElvenSectionSecond = elvenSectionSecond;
    }

    public bool OverLapsOneOrTheOther()
    {
        return SectionAContainsSectionIdWithinRangeFromSectionB(ElvenSectionFirst, ElvenSectionSecond) 
               || SectionAContainsSectionIdWithinRangeFromSectionB(ElvenSectionSecond, ElvenSectionFirst);
    }

    private bool SectionAContainsSectionIdWithinRangeFromSectionB(Section sectionA, Section sectionB)
    {
        var secondLowerBoundary = sectionB.LowerBoundary;
        var secondUpperBoundary = sectionB.UpperBoundary;
        return sectionA.ContainsSectionIdWithinRange(secondLowerBoundary)
               || sectionA.ContainsSectionIdWithinRange(secondUpperBoundary);
    }

    public bool IsContainedByOneOrTheOther()
    {
        return SectionAContainsSectionB(ElvenSectionFirst, ElvenSectionSecond)
               || SectionAContainsSectionB(ElvenSectionSecond, ElvenSectionFirst);
    }

    private bool SectionAContainsSectionB(Section sectionA, Section sectionB)
    {
        return LowerBoundaryIsLessThanOrEqualTo(sectionA, sectionB)
               && UpperBoundaryIsMoreThanOrEqualTo(sectionA, sectionB);
    }

    private bool LowerBoundaryIsLessThanOrEqualTo(Section firstSection, Section otherSection)
    {
        return firstSection.LowerBoundary <= otherSection.LowerBoundary;
    }

    private bool UpperBoundaryIsMoreThanOrEqualTo(Section firstSection, Section otherSection)
    {
        return firstSection.UpperBoundary >= otherSection.UpperBoundary;
    }
}